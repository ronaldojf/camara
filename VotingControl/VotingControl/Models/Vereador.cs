using System;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VotingControl.Bases;
using VotingControl.Attributes;

namespace VotingControl
{
    [Table("vereadores")]
    public class Vereador : ActiveRecorder<Vereador>
    {
        private string _cpf = "";

        /// <summary>
        /// Inicializa uma nova instância de Vereador
        /// </summary>
        public Vereador() : base()
        {
            this.Projetos = new List<Projeto>();
            this.Votos = new List<Voto>();
            this.Suplentes = new List<Suplente>();
        }

        /// <summary>
        /// Quantidade máxima de caracteres de campos string
        /// </summary>
        public struct MaxCaracteres
        {
            public static int Nome = 60;
            public static int Cpf = 11;
        }

        public Partido Partido { get; set; }
        public Cadeira Cadeira { get; set; }
        public List<Projeto> Projetos { get; set; }
        public List<Voto> Votos { get; set; }
        public List<Suplente> Suplentes { get; set; }
        
        [Column("id")] [PrimaryKey]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("sexo", Type = MySqlDbType.Int32)]
        public Sexos Sexo { get; set; }

        [Column("cpf")]
        public string Cpf
        {
            get { return this._cpf; }
            set
            {
                this._cpf = Regex.Replace(value, @"\D", "");
            }
        }

        public int PartidoId { get; set; }

        [Column("foto")]
        public string Foto { get; set; }
        
        /// <summary>
        /// Cria um novo vereador ou atualiza um vereador existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Save()
        {
            if (this.Validate())
                return base.Save(this);
            else
                return false;
        }

        /// <summary>
        /// Exclui um vereador existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Delete()
        {
            return base.Delete(this);
        }

        /// <summary>
        /// Salva o objeto atual e seus respectivos relacionamentos de muitos para muitos
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool SaveWithRelationship()
        {
            if (this.Validate())
            {
                Program.Connection.Open();
                bool isOk = false;

                using (var transaction = Program.Connection.BeginTransaction())
                {
                    isOk = this.Save();
                    int ultimoIdVereador = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                        .SearchInDataTable()
                        .Rows[0]["last_id"]);

                    foreach (Suplente suplente in this.Suplentes)
                    {
                        if (!isOk)
                            break;
                        
                        isOk = suplente.Save();
                    }

                    if (isOk)
                    {
                        int ultimoIdSuplente = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                            .SearchInDataTable()
                            .Rows[0]["last_id"]);

                        string[] fields = new string[] { "suplente_id", "vereador_id" };
                        object[] values = new object[] { ultimoIdSuplente, ultimoIdVereador };
                        MySqlDbType[] types = new MySqlDbType[] { MySqlDbType.Int32, MySqlDbType.Int32 };

                        DBComunicator throughTableBase = new DBComunicator("suplentes_vereadores");
                        isOk = throughTableBase.ExecuteInsert(
                            new List<string>(fields),
                            new List<object>(values),
                            new List<MySqlDbType>(types));
                    }

                    if (isOk)
                        transaction.Commit();
                    else
                        transaction.Rollback();
                }

                Program.Connection.Close();
                return isOk;
            }
            else
                return false;
        }

        /// <summary>
        /// Verifica se os atributos possuem erros
        /// </summary>
        /// <returns>Retorna true se for válido, senão false</returns>
        public bool Validate()
        {
            base.ClearErrors();

            Validator validateNome = new Validator(this.Nome, "nome");
            validateNome.Presence().LessOrEqualsThan(MaxCaracteres.Nome);

            Validator validateSexo = new Validator(this.Sexo, "sexo");
            validateSexo.Presence(true);

            Validator validateCpf = new Validator(this.Cpf, "CPF");
            validateCpf.Presence().CpfVerification().Uniqueness<Vereador>();

            Validator validatePartidoId = new Validator(this.PartidoId, "partido_id");
            validatePartidoId.Presence();

            Validator validateFoto = new Validator(this.Foto, "foto");
            validateFoto.Presence();

            if (!validateNome.IsValid || !validateSexo.IsValid || !validateCpf.IsValid ||
                !validatePartidoId.IsValid || !validateFoto.IsValid)
            {
                base.AddMessages(validateNome.Errors);
                base.AddMessages(validateSexo.Errors);
                base.AddMessages(validateCpf.Errors);
                base.AddMessages(validatePartidoId.Errors);
                base.AddMessages(validateFoto.Errors);
                return false;
            }
            else
                return true;
        }
    }
}

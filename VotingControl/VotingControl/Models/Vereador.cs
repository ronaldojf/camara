using System;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingControl.Bases;
using VotingControl.Attributes;

namespace VotingControl
{
    [Table("vereadores")]
    public class Vereador : ActiveRecorder<Vereador>
    {
        private string _nome { get; set; }
        private Sexos _sexo { get; set; }
        private string _cpf { get; set; }
        private int _partidoId { get; set; }
        private string _foto { get; set; }

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
        public string Nome
        {
            get { return _nome; }
            set
            {
                Validator validate = new Validator(value, "nome");
                validate.Presence().LessOrEqualsThan(MaxCaracteres.Nome);

                if (validate.IsValid)
                    this._nome = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("sexo", Type = MySqlDbType.Int32)]
        public Sexos Sexo
        {
            get { return _sexo; }
            set
            {
                Validator validate = new Validator(value, "sexo");
                validate.Presence(true);

                if (validate.IsValid)
                    this._sexo = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("cpf")]
        public string Cpf
        {
            get { return _cpf; }
            set
            {
                Validator validate = new Validator(value, "cpf");
                validate.Presence().CpfVerification();

                if (validate.IsValid)
                    this._cpf = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("partido_id")]
        public int PartidoId
        {
            get { return _partidoId; }
            set
            {
                Validator validate = new Validator(value, "partido_id");
                validate.Presence();

                if (validate.IsValid)
                    this._partidoId = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("foto")]
        public string Foto
        {
            get { return _foto; }
            set
            {
                Validator validate = new Validator(value, "foto");
                validate.Presence();

                if (validate.IsValid)
                    this._foto = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        /// <summary>
        /// Cria um novo vereador ou atualiza um vereador existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Salvar()
        {
            if (this.UnicidadeCpf())
                return base.Salvar(this);
            else
                return false;
        }

        /// <summary>
        /// Exclui um vereador existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Deletar()
        {
            return base.Deletar(this);
        }

        /// <summary>
        /// Salva o objeto atual e seus respectivos relacionamentos de muitos para muitos
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool SalvarComRelacionamentos()
        {
            if (this.UnicidadeCpf())
            {
                Program.Connection.Open();
                bool isOk = false;

                using (var transaction = Program.Connection.BeginTransaction())
                {
                    isOk = this.Salvar();
                    int ultimoIdVereador = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                        .BuscarEmDataTable()
                        .Rows[0]["last_id"]);

                    foreach (Suplente suplente in this.Suplentes)
                    {
                        if (!isOk)
                            break;
                        
                        isOk = suplente.Salvar();
                    }

                    if (isOk)
                    {
                        int ultimoIdSuplente = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                            .BuscarEmDataTable()
                            .Rows[0]["last_id"]);

                        string[] fields = new string[] { "suplente_id", "vereador_id" };
                        object[] values = new object[] { ultimoIdSuplente, ultimoIdVereador };
                        MySqlDbType[] types = new MySqlDbType[] { MySqlDbType.Int32, MySqlDbType.Int32 };

                        DBComunicator throughTableBase = new DBComunicator("suplentes_vereadores");
                        isOk = throughTableBase.ExecutarInsert(
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
        /// Valida se o CPF é único no banco de dados
        /// </summary>
        /// <returns>Retorna true se não existir, senão false</returns>
        public bool UnicidadeCpf()
        {
            return new Validator(this._cpf, "cpf").Uniqueness<Vereador>().IsValid;
        }
    }
}

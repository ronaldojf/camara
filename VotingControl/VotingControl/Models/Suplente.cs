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
    [Table("suplentes")]
    public class Suplente : ActiveRecorder<Suplente>
    {
        /// <summary>
        /// Inicializa uma nova instância de Suplente
        /// </summary>
        public Suplente() : base()
        {
            this.Vereadores = new List<Vereador>();
        }

        /// <summary>
        /// Quantidade máxima de caracteres de campos string
        /// </summary>
        public struct MaxCaracteres
        {
            public static int Nome = 60;
            public static int Cpf = 11;
        }

        [HasAndBelongsToMany("suplentes_vereadores", "suplente_id", "vereador_id")]
        public virtual List<Vereador> Vereadores { get; set; }

        [Column("id")] [PrimaryKey]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        /// <summary>
        /// Cria um novo suplente ou atualiza um suplente existente
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
        /// Exclui um suplente existente
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
                    int ultimoIdSuplente = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                        .SearchInDataTable()
                        .Rows[0]["last_id"]);

                    foreach (Vereador vereador in this.Vereadores)
                    {
                        if (!isOk)
                            break;

                        isOk = vereador.Save();
                    }

                    if (isOk)
                    {
                        int ultimoIdVereador = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
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

            Validator validateCpf = new Validator(this.Cpf, "cpf");
            validateCpf.Presence().CpfVerification().Uniqueness<Suplente>();

            if (!validateNome.IsValid || !validateCpf.IsValid)
            {
                base.AddMessages(validateNome.Errors);
                base.AddMessages(validateCpf.Errors);
                return false;
            }
            else
                return true;
        }
    }
}

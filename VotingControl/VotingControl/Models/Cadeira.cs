using System;
using System.Collections.Generic;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingControl.Bases;
using VotingControl.Attributes;

namespace VotingControl
{
    [Table("cadeiras")]
    public class Cadeira : ActiveRecorder<Cadeira>
    {
        /// <summary>
        /// Inicializa uma nova instância de Cadeira
        /// </summary>
        public Cadeira() : base()
        {
            this.Sessoes = new List<Sessao>();
        }

        /// <summary>
        /// Quantidade máxima de caracteres de campos string
        /// </summary>
        public struct MaxCaracteres
        {
            public static int Identificador = 10;
        }

        [BelongsTo("vereador")]
        public Vereador Vereador { get; set; }

        [HasAndBelongsToMany("cadeiras_sessoes", "cadeira_id", "sessao_id")]
        public List<Sessao> Sessoes { get; set; }

        [Column("id")] [PrimaryKey]
        public int Id { get; set; }

        [Column("identificador")]
        public string Identificador { get; set; }

        [Column("vereador_id")]
        public int VereadorId { get; set; }

        /// <summary>
        /// Cria um nova cadeira ou atualiza uma cadeira existente
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
        /// Exclui uma cadeira existente
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
                    int ultimoIdCadeira = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                        .SearchInDataTable()
                        .Rows[0]["last_id"]);

                    foreach (Sessao sessao in this.Sessoes)
                    {
                        if (!isOk)
                            break;

                        isOk = sessao.Save();
                    }

                    if (isOk)
                    {
                        int ultimoIdSessao = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                            .SearchInDataTable()
                            .Rows[0]["last_id"]);

                        string[] fields = new string[] { "sessao_id", "cadeira_id" };
                        object[] values = new object[] { ultimoIdSessao, ultimoIdCadeira };
                        MySqlDbType[] types = new MySqlDbType[] { MySqlDbType.Int32, MySqlDbType.Int32 };

                        DBComunicator throughTableBase = new DBComunicator("cadeiras_sessoes");
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

            Validator validateIdentificador = new Validator(this.Identificador, "identificador");
            validateIdentificador.Presence().LessOrEqualsThan(MaxCaracteres.Identificador).Uniqueness<Cadeira>();

            Validator validateVereadorId = new Validator(this.VereadorId, "vereador_id");
            validateVereadorId.Presence();

            if (!validateIdentificador.IsValid || !validateVereadorId.IsValid)
            {
                base.AddMessages(validateIdentificador.Errors);
                base.AddMessages(validateVereadorId.Errors);
                return false;
            }
            else
                return true;
        }
    }
}

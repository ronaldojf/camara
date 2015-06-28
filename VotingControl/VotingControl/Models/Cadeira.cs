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
        private string _identificador;
        private int _vereadorId;

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
        public string Identificador
        {
            get { return this._identificador; }
            set
            {
                Validator validate = new Validator(value, "identificador");
                validate.Presence().LessOrEqualsThan(MaxCaracteres.Identificador);

                if (validate.IsValid)
                    this._identificador = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("vereador_id")]
        public int VereadorId
        {
            get { return this._vereadorId; }
            set
            {
                Validator validate = new Validator(value, "vereador_id");
                validate.Presence();

                if (validate.IsValid)
                    this._vereadorId = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        /// <summary>
        /// Cria um nova cadeira ou atualiza uma cadeira existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Salvar()
        {
            if (this.UnicidadeIdentificador())
                return base.Salvar(this);
            else
                return false;
        }

        /// <summary>
        /// Exclui uma cadeira existente
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
            if (this.UnicidadeIdentificador())
            {
                Program.Connection.Open();
                bool isOk = false;

                using (var transaction = Program.Connection.BeginTransaction())
                {
                    isOk = this.Salvar();
                    int ultimoIdCadeira = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                        .BuscarEmDataTable()
                        .Rows[0]["last_id"]);

                    foreach (Sessao sessao in this.Sessoes)
                    {
                        if (!isOk)
                            break;

                        isOk = sessao.Salvar();
                    }

                    if (isOk)
                    {
                        int ultimoIdSessao = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                            .BuscarEmDataTable()
                            .Rows[0]["last_id"]);

                        string[] fields = new string[] { "sessao_id", "cadeira_id" };
                        object[] values = new object[] { ultimoIdSessao, ultimoIdCadeira };
                        MySqlDbType[] types = new MySqlDbType[] { MySqlDbType.Int32, MySqlDbType.Int32 };

                        DBComunicator throughTableBase = new DBComunicator("cadeiras_sessoes");
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
        /// Valida se o indicador é único no banco de dados
        /// </summary>
        /// <returns>Retorna true se não existir, senão false</returns>
        public bool UnicidadeIdentificador()
        {
            return new Validator(this._identificador, "identificador").Uniqueness<Cadeira>().IsValid;
        }
    }
}

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
    [Table("sessoes")]
    public class Sessao : ActiveRecorder<Sessao>
    {
        private string _titulo;
        private TiposDeSessao _tipo;
        private DateTime _inicio;
        private DateTime _fim;

        /// <summary>
        /// Inicializa uma nova instância de Sessão
        /// </summary>
        public Sessao() : base()
        {
            this.Votos = new List<Voto>();
            this.Cadeiras = new List<Cadeira>();
        }

        /// <summary>
        /// Quantidade máxima de caracteres de campos string
        /// </summary>
        public struct MaxCaracteres
        {
            public static int Titulo = 150;
        }

        public List<Voto> Votos { get; set; }
        public List<Cadeira> Cadeiras { get; set; }

        [Column("id")] [PrimaryKey]
        public int Id { get; set; }

        [Column("titulo")]
        public string Titulo
        {
            get { return this._titulo; }
            set
            {
                Validator validate = new Validator(value, "titulo");
                validate.Presence().LessOrEqualsThan(MaxCaracteres.Titulo);

                if (validate.IsValid)
                    this._titulo = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("tipo", Type = MySqlDbType.Int32)]
        public TiposDeSessao Tipo
        {
            get { return this._tipo; }
            set
            {
                Validator validate = new Validator(value, "tipo");
                validate.Presence();

                if (validate.IsValid)
                    this._tipo = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("inicio")]
        public DateTime Inicio
        {
            get { return this._inicio; }
            set
            {
                Validator validate = new Validator(value, "inicio");
                validate.SameDateOfTodayOrGreater().LessOrEqualsThan(this._fim);

                if (validate.IsValid)
                    this._inicio = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("fim")]
        public DateTime Fim
        {
            get { return this._fim; }
            set
            {
                Validator validate = new Validator(value, "fim");
                validate.SameDateOfTodayOrGreater().GreaterThan(this._inicio);

                if (validate.IsValid)
                    this._fim = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        /// <summary>
        /// Cria uma nova sessão ou atualiza uma sessão existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Salvar()
        {
            return base.Salvar(this);
        }

        /// <summary>
        /// Exclui uma sessão existente
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
            Program.Connection.Open();
            bool isOk = false;

            using (var transaction = Program.Connection.BeginTransaction())
            {
                isOk = this.Salvar();
                int ultimoIdSessao = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                    .BuscarEmDataTable()
                    .Rows[0]["last_id"]);

                foreach (Cadeira cadeira in this.Cadeiras)
                {
                    if (!isOk)
                        break;

                    isOk = cadeira.Salvar();
                }

                if (isOk)
                {
                    int ultimoIdCadeira = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
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
    }
}

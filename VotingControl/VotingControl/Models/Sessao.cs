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
        public string Titulo { get; set; }
        [Column("tipo", Type = MySqlDbType.Int32)]
        public TiposDeSessao Tipo { get; set; }

        [Column("inicio")]
        public DateTime Inicio { get; set; }

        [Column("fim")]
        public DateTime Fim { get; set; }

        /// <summary>
        /// Cria uma nova sessão ou atualiza uma sessão existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Salvar()
        {
            if (this.Validar())
                return base.Salvar(this);
            else
                return false;
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
            if (!this.Validar())
                return false;

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

        /// <summary>
        /// Verifica se os atributos possuem erros
        /// </summary>
        /// <returns>Retorna true se for válido, senão false</returns>
        public bool Validar()
        {
            base.LimparErros();

            Validator validateTitulo = new Validator(this.Titulo, "titulo");
            validateTitulo.Presence().LessOrEqualsThan(MaxCaracteres.Titulo);

            Validator validateTipo = new Validator(this.Tipo, "tipo");
            validateTipo.Presence();

            Validator validateInicio = new Validator(this.Inicio, "inicio");
            validateInicio.SameDateOfTodayOrGreater().LessThan(this.Fim);
            base.AddMensagens(validateInicio.Errors);

            Validator validateFim = new Validator(this.Fim, "fim");
            validateFim.SameDateOfTodayOrGreater().GreaterThan(this.Inicio);
            base.AddMensagens(validateFim.Errors);

            if (!validateTitulo.IsValid || !validateTipo.IsValid || !validateInicio.IsValid || !validateFim.IsValid)
            {
                base.AddMensagens(validateTitulo.Errors);
                base.AddMensagens(validateTipo.Errors);
                base.AddMensagens(validateInicio.Errors);
                base.AddMensagens(validateFim.Errors);
                return false;
            }
            else
                return true;
        }
    }
}

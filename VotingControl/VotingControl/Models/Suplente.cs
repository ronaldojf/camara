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
        private string _nome { get; set; }
        private string _cpf { get; set; }

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

        /// <summary>
        /// Cria um novo suplente ou atualiza um suplente existente
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
        /// Exclui um suplente existente
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
                    int ultimoIdSuplente = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
                        .BuscarEmDataTable()
                        .Rows[0]["last_id"]);

                    foreach (Vereador vereador in this.Vereadores)
                    {
                        if (!isOk)
                            break;

                        isOk = vereador.Salvar();
                    }

                    if (isOk)
                    {
                        int ultimoIdVereador = Convert.ToInt32(this.Select("LAST_INSERT_ID() as last_id")
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
            return new Validator(this._cpf, "cpf").Uniqueness<Suplente>().IsValid;
        }
    }
}

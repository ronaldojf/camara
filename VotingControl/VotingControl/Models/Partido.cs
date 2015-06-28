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
    [Table("partidos")]
    public class Partido : ActiveRecorder<Partido>
    {
        private string _sigla;
        
        /// <summary>
        /// Inicializa uma nova instância de Partido
        /// </summary>
        public Partido() : base()
        {
            this.Vereadores = new List<Vereador>();
        }

        /// <summary>
        /// Quantidade máxima de caracteres de campos string
        /// </summary>
        public struct MaxCaracteres
        {
            public static int Sigla = 10;
        }

        public List<Vereador> Vereadores { get; set; }

        [Column("id")] [PrimaryKey]
        public int Id { get; set; }

        [Column("sigla")]
        public string Sigla
        {
            get { return this._sigla; }
            set
            {
                Validator validate = new Validator(value, "sigla");
                validate.Presence().LessOrEqualsThan(MaxCaracteres.Sigla);

                if (validate.IsValid)
                    this._sigla = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        /// <summary>
        /// Cria um novo partido ou atualiza um partido existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Salvar()
        {
            if (this.UnicidadeSigla())
                return base.Salvar(this);
            else
                return false;
        }

        /// <summary>
        /// Exclui um partido existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Deletar()
        {
            return base.Deletar(this);
        }

        /// <summary>
        /// Valida se a sigla é única no banco de dados
        /// </summary>
        /// <returns>Retorna true se não existir, senão false</returns>
        public bool UnicidadeSigla()
        {
            return new Validator(this._sigla, "sigla").Uniqueness<Partido>().IsValid;
        }
    }
}

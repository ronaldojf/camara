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
        public string Sigla { get; set; }

        /// <summary>
        /// Cria um novo partido ou atualiza um partido existente
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
        /// Exclui um partido existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Delete()
        {
            return base.Delete(this);
        }

        /// <summary>
        /// Verifica se os atributos possuem erros
        /// </summary>
        /// <returns>Retorna true se for válido, senão false</returns>
        public bool Validate()
        {
            base.ClearErrors();

            Validator validateSigla = new Validator(this.Sigla, "sigla");
            validateSigla.Presence().LessOrEqualsThan(MaxCaracteres.Sigla).Uniqueness<Partido>();

            if (!validateSigla.IsValid)
            {
                base.AddMessages(validateSigla.Errors);
                return false;
            }
            else
                return true;
        }
    }
}

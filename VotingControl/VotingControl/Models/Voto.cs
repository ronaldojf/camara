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
    [Table("votos")]
    public class Voto : ActiveRecorder<Voto>
    {
        /// <summary>
        /// Inicializa uma nova instância de Voto
        /// </summary>
        public Voto() : base() { }

        [BelongsTo("projetos")]
        public Projeto Projeto { get; set; }

        [BelongsTo("sessoes")]
        public Sessao Sessao { get; set; }

        [BelongsTo("vereadores")]
        public Vereador Vereador { get; set; }

        [Column("id")] [PrimaryKey]
        public int Id { get; set; }

        [Column("tipo", Type = MySqlDbType.Int32)]
        public TiposDeVoto Tipo { get; set; }

        [Column("projeto_id")]
        public int ProjetoId { get; set; }

        [Column("vereador_id")]
        public int VereadorId { get; set; }

        [Column("sessao_id")]
        public int SessaoId { get; set; }
        /// <summary>
        /// Cria um novo voto ou atualiza um voto existente
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
        /// Exclui um voto existente
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

            Validator validateTipo = new Validator(this.Tipo, "tipo");
            validateTipo.Presence(true);

            Validator validateProjetoId = new Validator(this.ProjetoId, "projeto_id");
            validateProjetoId.Presence();

            Validator validateVereadorId = new Validator(this.VereadorId, "vereador_id");
            validateVereadorId.Presence();

            Validator validateSessaoId = new Validator(this.SessaoId, "sessao_id");
            validateSessaoId.Presence();

            if (validateTipo.IsValid || validateProjetoId.IsValid || validateVereadorId.IsValid || validateSessaoId.IsValid)
            {
                base.AddMessages(validateTipo.Errors);
                base.AddMessages(validateProjetoId.Errors);
                base.AddMessages(validateVereadorId.Errors);
                base.AddMessages(validateSessaoId.Errors);
                return false;
            }
            else
                return true;
        }
    }
}

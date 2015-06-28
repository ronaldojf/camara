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
        private TiposDeVoto _tipo { get; set; }
        private int _projetoId { get; set; }
        private int _vereadorId { get; set; }
        private int _sessaoId { get; set; }

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
        public TiposDeVoto Tipo
        {
            get { return _tipo; }
            set
            {
                Validator validate = new Validator(value, "tipo");
                validate.Presence(true);

                if (validate.IsValid)
                    this._tipo = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("projeto_id")]
        public int ProjetoId
        {
            get { return _projetoId; }
            set
            {
                Validator validate = new Validator(value, "projeto_id");
                validate.Presence();

                if (validate.IsValid)
                    this._projetoId = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("vereador_id")]
        public int VereadorId
        {
            get { return _vereadorId; }
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

        [Column("sessao_id")]
        public int SessaoId
        {
            get { return _sessaoId; }
            set
            {
                Validator validate = new Validator(value, "sessao_id");
                validate.Presence();

                if (validate.IsValid)
                    this._sessaoId = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        /// <summary>
        /// Cria um novo voto ou atualiza um voto existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Salvar()
        {
            return base.Salvar(this);
        }

        /// <summary>
        /// Exclui um voto existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Deletar()
        {
            return base.Deletar(this);
        }
    }
}

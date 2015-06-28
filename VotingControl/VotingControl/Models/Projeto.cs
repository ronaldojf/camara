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
    [Table("projetos")]
    public class Projeto : ActiveRecorder<Projeto>
    {
        private int _vereadorId;
        private int _sessaoId;
        private string _titulo;

        /// <summary>
        /// Inicializa uma nova instância de Projeto
        /// </summary>
        public Projeto() : base()
        {
            this.Votos = new List<Voto>();
        }

        /// <summary>
        /// Quantidade máxima de caracteres de campos string
        /// </summary>
        public struct MaxCaracteres
        {
            public static int Titulo = 150;
        }

        public Vereador Vereador { get; set; }
        public Sessao Sessao { get; set; }
        public List<Voto> Votos { get; set; }

        [Column("id")] [PrimaryKey]
        public int Id { get; set; }

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

        [Column("sessao_id")]
        public int SessaoId
        {
            get { return this._sessaoId; }
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

        /// <summary>
        /// Cria um novo projeto ou atualiza um projeto existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Salvar()
        {
            return base.Salvar(this);
        }

        /// <summary>
        /// Exclui um projeto existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Deletar()
        {
            return base.Deletar(this);
        }
    }
}

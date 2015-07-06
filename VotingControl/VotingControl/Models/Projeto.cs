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
        public int VereadorId { get; set; }

        [Column("sessao_id")]
        public int SessaoId { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        /// <summary>
        /// Cria um novo projeto ou atualiza um projeto existente
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
        /// Exclui um projeto existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Deletar()
        {
            return base.Deletar(this);
        }

        /// <summary>
        /// Verifica se os atributos possuem erros
        /// </summary>
        /// <returns>Retorna true se for válido, senão false</returns>
        public bool Validar()
        {
            base.LimparErros();

            Validator validateVereadorId = new Validator(this.VereadorId, "vereador_id").Presence();
            Validator validateSessaoId = new Validator(this.SessaoId, "sessao_id").Presence();
            Validator validateTitulo = new Validator(this.Titulo, "titulo").Presence().LessOrEqualsThan(MaxCaracteres.Titulo);

            if (!validateVereadorId.IsValid || !validateSessaoId.IsValid || !validateTitulo.IsValid)
            {
                base.AddMensagens(validateVereadorId.Errors);
                base.AddMensagens(validateSessaoId.Errors);
                base.AddMensagens(validateTitulo.Errors);
                return false;
            }
            else
                return true;
        }
    }
}

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
    [Table("administradores")]
    public class Administrador : ActiveRecorder<Administrador>
    {
        /// <summary>
        /// Inicializa uma nova instância de Administrador
        /// </summary>
        public Administrador() : base() { }

        /// <summary>
        /// Quantidade máxima de caracteres de campos string
        /// </summary>
        public struct MaxCaracteres
        {
            public static int Usuario = 15;
            public static int MinSenha = 8;
            public static int MaxSenha = 20;
        }

        [Column("id")] [PrimaryKey]
        public int Id { get; set; }

        [Column("usuario")]
        public string Usuario { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        /// <summary>
        /// Cria um novo administrador ou atualiza um administrador existente
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
        /// Exclui um administrador existente
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

            Validator validateSenha = new Validator(this.Senha, "senha");
            validateSenha.Presence().Between(MaxCaracteres.MinSenha, MaxCaracteres.MaxSenha);

            Validator validateUsuario = new Validator(this.Usuario, "usuario");
            validateUsuario.Presence().LessOrEqualsThan(MaxCaracteres.Usuario).Uniqueness<Administrador>();

            if (!validateUsuario.IsValid || !validateSenha.IsValid)
            {
                base.AddMensagens(validateUsuario.Errors);
                base.AddMensagens(validateSenha.Errors);
                return false;
            }
            else
                return true;
        }

        public bool Login(string usuario, string senha)
        {
            return this.Where("BINARY usuario = {0} AND BINARY senha = {1}", usuario, senha).Exists();
        }
    }
}

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
        private string _usuario;
        private string _senha;

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
        public string Usuario
        {
            get { return this._usuario; }
            set
            {
                Validator validate = new Validator(value, "usuario");
                validate.Presence().LessOrEqualsThan(MaxCaracteres.Usuario).Uniqueness<Administrador>();

                if (validate.IsValid)
                    this._usuario = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        [Column("senha")]
        public string Senha
        {
            get { return this._senha; }
            set
            {
                Validator validate = new Validator(value, "senha");
                validate.Presence().Between(MaxCaracteres.MinSenha, MaxCaracteres.MaxSenha);

                if (validate.IsValid)
                   this. _senha = value;
                else
                    base.AddMensagens(validate.Errors);
            }
        }

        /// <summary>
        /// Cria um novo administrador ou atualiza um administrador existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Salvar()
        {
            return base.Salvar(this);
        }

        /// <summary>
        /// Exclui um administrador existente
        /// </summary>
        /// <returns>Retorna true se sucesso, em caso de falha, false</returns>
        public bool Deletar()
        {
            return base.Deletar(this);
        }

        public bool Login(string usuario, string senha)
        {
            return this.Where("BINARY usuario = {0} AND BINARY senha = {1}", usuario, senha).Exists();
        }
    }
}

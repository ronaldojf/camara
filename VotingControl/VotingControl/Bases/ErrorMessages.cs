using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingControl.Bases
{
    public class ErrorMessages
    {
        public ErrorMessages()
        {
            this.PossuiErro = false;
            this.Erros = new DataTable();
            this.Erros.Columns.Add("Atributo", typeof(string));
            this.Erros.Columns.Add("Mensagem", typeof(string));
        }

        private DataTable Erros { get; set; }
        private bool PossuiErro { get; set; }

        /// <summary>
        /// Mostra uma mensagem de erro de um atributo específico e depois a exclui.
        /// </summary>
        /// <param name="nomeAtributo">Nome do atributo para procurar a mensagem</param>
        /// <returns>Retorna a mensagem de erro.</returns>
        public string MostrarMensagem(string nomeAtributo)
        {
            string msg = "";

            foreach (DataRow row in this.Erros.Rows)
            {
                if (row["Atributo"].ToString().ToLower() == nomeAtributo.ToLower())
                {
                    msg = row["Mensagem"].ToString();
                    row.Delete();
                    this.PossuiErro = false;
                    break;
                }
            }

            return msg;
        }

        /// <summary>
        /// Limpa erros armazenados
        /// </summary>
        public void LimparErros()
        {
            this.Erros.Clear();
            this.PossuiErro = false;
        }

        /// <summary>
        /// Verifica se há algum erro em um atributo específico.
        /// </summary>
        /// <param name="nomeAtributo">Nome do atributo</param>
        /// <returns>Retorna true caso possua algum erro, senão retorna false</returns>
        public bool PossuiErrosEm(string nomeAtributo)
        {
            foreach (DataRow row in this.Erros.Rows)
            {
                if (row["Atributo"].ToString().ToLower() == nomeAtributo.ToLower())
                {
                    this.PossuiErro = true;
                    break;
                }
                else
                    this.PossuiErro = false;
            }

            return this.PossuiErro;
        }

        /// <summary>
        /// Verifica se há algum erro em qualquer atributo.
        /// </summary>
        /// <returns>Retorna true caso possua algum erro, senão retorna false</returns>
        public bool PossuiErros()
        {
            if (this.Erros.Rows.Count > 0)
                this.PossuiErro = true;

            return this.PossuiErro;
        }

        /// <summary>
        /// Adiciona uma mensagem de erro para um atributo
        /// </summary>
        /// <param name="_nomeAtributo">Nome do atributo, será usado para buscar a mensagem de erro</param>
        /// <param name="_mensagem">Mensagem de erro para o atributo</param>
        public void AddMensagem(string _nomeAtributo, string _mensagem)
        {
            this.Erros.Rows.Add(new object[] { _nomeAtributo, _mensagem });
        }

        public void AddMensagens(DataTable validatorErrors)
        {
            this.Erros.Merge(validatorErrors, true);
        }
    }
}

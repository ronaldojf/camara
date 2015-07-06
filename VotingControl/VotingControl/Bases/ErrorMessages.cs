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
            this.HasError = false;
            this.Errors = new DataTable();
            this.Errors.Columns.Add("Atributo", typeof(string));
            this.Errors.Columns.Add("Mensagem", typeof(string));
        }

        private DataTable Errors { get; set; }
        private bool HasError { get; set; }

        /// <summary>
        /// Mostra uma mensagem de erro de um atributo específico e depois a exclui.
        /// </summary>
        /// <param name="attrName">Nome do atributo para procurar a mensagem</param>
        /// <returns>Retorna a mensagem de erro.</returns>
        public string ShowMessage(string attrName)
        {
            string msg = "";

            foreach (DataRow row in this.Errors.Rows)
            {
                if (row["Atributo"].ToString().ToLower() == attrName.ToLower())
                {
                    msg = row["Mensagem"].ToString();
                    row.Delete();
                    this.HasError = false;
                    break;
                }
            }

            return msg;
        }

        /// <summary>
        /// Limpa erros armazenados
        /// </summary>
        public void ClearErrors()
        {
            this.Errors.Clear();
            this.HasError = false;
        }

        /// <summary>
        /// Verifica se há algum erro em um atributo específico.
        /// </summary>
        /// <param name="attrName">Nome do atributo</param>
        /// <returns>Retorna true caso possua algum erro, senão retorna false</returns>
        public bool HasErrorsOn(string attrName)
        {
            foreach (DataRow row in this.Errors.Rows)
            {
                if (row["Atributo"].ToString().ToLower() == attrName.ToLower())
                {
                    this.HasError = true;
                    break;
                }
                else
                    this.HasError = false;
            }

            return this.HasError;
        }

        /// <summary>
        /// Verifica se há algum erro em qualquer atributo.
        /// </summary>
        /// <returns>Retorna true caso possua algum erro, senão retorna false</returns>
        public bool HasErrors()
        {
            if (this.Errors.Rows.Count > 0)
                this.HasError = true;

            return this.HasError;
        }

        /// <summary>
        /// Adiciona uma mensagem de erro para um atributo
        /// </summary>
        /// <param name="attrName">Nome do atributo, será usado para buscar a mensagem de erro</param>
        /// <param name="message">Mensagem de erro para o atributo</param>
        public void AddMessage(string attrName, string message)
        {
            this.Errors.Rows.Add(new object[] { attrName, message });
        }

        public void AddMessages(DataTable validatorErrors)
        {
            this.Errors.Merge(validatorErrors, true);
        }
    }
}

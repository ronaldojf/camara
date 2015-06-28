using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VotingControl
{
    public class Decorator
    {
        /// <summary>
        /// Exibe uma MessageBox para Erros
        /// </summary>
        /// <param name="text">Texto a ser exibido na MessageBox</param>
        /// <returns>Retorna um DialogResult que indica qual opção foi escolhida pelo usuário</returns>
        public static DialogResult MessageBoxError(string text)
        {
            return MessageBoxError(text, "Erro");
        }

        /// <summary>
        /// Exibe uma MessageBox para Erros
        /// </summary>
        /// <param name="text">Texto a ser exibido na MessageBox</param>
        /// <param name="caption">Título da MessageBox</param>
        /// <returns>Retorna um DialogResult que indica qual opção foi escolhida pelo usuário</returns>
        public static DialogResult MessageBoxError(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Exibe uma MessageBox para informar Sucesso
        /// </summary>
        /// <param name="text">Texto a ser exibido na MessageBox</param>
        /// <returns>Retorna um DialogResult que indica qual opção foi escolhida pelo usuário</returns>
        public static DialogResult MessageBoxSuccess(string text)
        {
            return MessageBoxSuccess(text, "Sucesso");
        }

        /// <summary>
        /// Exibe uma MessageBox para informar Sucesso
        /// </summary>
        /// <param name="text">Texto a ser exibido na MessageBox</param>
        /// <param name="caption">Título da MessageBox</param>
        /// <returns>Retorna um DialogResult que indica qual opção foi escolhida pelo usuário</returns>
        public static DialogResult MessageBoxSuccess(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Coloca foco na primeira TextBox encontrada nos controles
        /// </summary>
        /// <param name="controls">Controles onde possui TextBox para por foco</param>
        public static void FocusOnFirstTextBox(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    (ctrl as TextBox).Focus();
                    break;
                }
            }
        }

        /// <summary>
        /// Limpa todos os controles passados
        /// </summary>
        /// <param name="controls">Controles onde possui os campos a serem limpados</param>
        public static void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is TextBox)
                    (ctrl as TextBox).Clear();
                else if (ctrl is MaskedTextBox)
                    (ctrl as MaskedTextBox).Clear();
                else if ((ctrl is ComboBox) && ((ctrl as ComboBox).Items.Count > 0))
                    (ctrl as ComboBox).SelectedIndex = 0;
                else if (ctrl is DateTimePicker)
                    (ctrl as DateTimePicker).Value = DateTime.Today;
                else if (ctrl is PictureBox)
                    (ctrl as PictureBox).ImageLocation = "";

            }
        }

        /// <summary>
        /// Limpa todos os controles passados de todas as TabPages informadas
        /// </summary>
        /// <param name="controls">Controles onde possui os campos a serem limpados</param>
        /// <param name="tabPages">TabPages que necessitam ter seus controles limpados</param>
        public static void ClearControls(Control.ControlCollection controls, TabControl.TabPageCollection tabPages)
        {
            foreach (TabPage tp in tabPages)
            {
                ClearControls(controls);
            }
        }

        /// <summary>
        /// Gera uma coleção de AutoComplete
        /// </summary>
        /// <param name="text">Texto de filtro para formular o AutoComplete</param>
        /// <param name="dataTable">Campos a serem filtrados para formular o AutoComplete</param>
        /// <returns></returns>
        public static AutoCompleteStringCollection AutoCompleteFor(string text, DataTable dataTable)
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            for (int i1 = 0; i1 < dataTable.Rows.Count; i1++)
            {
                for (int i2 = 0; i2 < dataTable.Rows[i1].ItemArray.Length; i2++)
                {
                    if (dataTable.Rows[i1][i2].ToString().ToLower().Contains(text.ToLower()))
                        autoComplete.Add(dataTable.Rows[i1][i2].ToString());
                }
            }

            return autoComplete;
        }

        public static void OpenForm(Form form, bool isDialog = false)
        {
            Cursor.Current = Cursors.AppStarting;
            form.Refresh();
            
            if (isDialog)
                form.ShowDialog();
            else
                form.Show();
        }

        public static void OpenForm(Form form, Form mdiForm)
        {
            Cursor.Current = Cursors.AppStarting;
            mdiForm.Refresh();

            form.MdiParent = mdiForm;
            form.Show();
        }

        public static bool DialogDecision(string sDecisao)
        {
            DialogResult Decisao = MessageBox.Show("Deseja realmente "+ sDecisao +" o registro ?",
               sDecisao, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            return Decisao == DialogResult.Yes;            
        }
    }
}

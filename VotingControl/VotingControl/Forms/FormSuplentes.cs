using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingControl
{
    public partial class FormSuplentes : Form
    {
        Suplente suplente;
        
        public FormSuplentes()
        {
            InitializeComponent();
        }

        private void FormSuplentes_Load(object sender, EventArgs e)
        {
            AtualizarMaximoCaracteres();
            suplente = new Suplente();
        }

        private void RecuperarDadosTextBox()
        {
            suplente.Nome = txNome.Text;
            suplente.Cpf = mtxCpf.Text;
        }

        private void AlternarFormErros()
        {
            errorProvider.SetError(txNome, suplente.ShowMessage("nome"));
            errorProvider.SetError(mtxCpf, suplente.ShowMessage("cpf"));
        }

        private void AtualizarMaximoCaracteres()
        {
            txNome.MaxLength = Suplente.MaxCaracteres.Nome;
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Refresh();

            RecuperarDadosTextBox();

            if (this.suplente.Save())
            {
                btLimpar_Click(sender, e);
                Decorator.MessageBoxSuccess("Registro criado com sucesso!");
            }
            else if (this.suplente.HasErrorsOn("criar"))
                Decorator.MessageBoxError(this.suplente.ShowMessage("criar"));

            AlternarFormErros();
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Decorator.ClearControls(pnContent.Controls);
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }

        private void btAbrirLista_Click(object sender, EventArgs e)
        {
        }

        private void FormSuplentes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btAbrirLista_Click(sender, e);
                    break;
            }
        }
        
    }
}

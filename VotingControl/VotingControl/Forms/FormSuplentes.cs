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
        public FormSuplentes()
        {
            InitializeComponent();
        }

        private void FormSuplentes_Load(object sender, EventArgs e)
        {
            suplente = new Suplente();
        }

        Suplente suplente;

        private void txNomeSuplente_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void RecuperarDadosTextBox()
        {
            suplente.Nome = txNome.Text;
            suplente.Cpf = mtxCpf.Text;
        }
        private void AlternaFormErros()
        {
            errorProvider.SetError(txNome, suplente.MostrarMensagem("nome"));
            errorProvider.SetError(mtxCpf, suplente.MostrarMensagem("cpf"));
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Refresh();

            RecuperarDadosTextBox();

            if (suplente.PossuiErros())
                AlternaFormErros();
            else
            {
                AlternaFormErros();

                if (suplente.Salvar())
                {
                    btLimpar_Click(sender, e);
                    Decorator.MessageBoxSuccess("Registro realizado com sucesso.");
                }
                else
                    Decorator.MessageBoxError(suplente.MostrarMensagem("criar"));

                Decorator.FocusOnFirstTextBox(pnContent.Controls);
            }
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

                case Keys.Enter:
                    btCadastar_Click(sender, e);


                    break;

                case Keys.Escape:
                    btLimpar_Click(sender, e);

                    break;

                case Keys.F5:
                    btAbrirLista_Click(sender, e);

                    break;


            }

        }
        
    }
}

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
    public partial class FormPartido : Form
    {
        private FormVereadores formVereadores;
        private Partido partido;

        public FormPartido(FormVereadores formVereadores = null)
        {
            InitializeComponent();
            this.formVereadores = formVereadores;
        }

        private void FormPartido_Load(object sender, EventArgs e)
        {
            AtualizarMaximoCaracteres();
            this.partido = new Partido();
        }

        private void RecuperarDadosTextbox()
        {
            this.partido.Sigla = txSigla.Text.ToUpper();
        }

        private void AlternarFormErros()
        {
            errorProvider1.SetError(txSigla, partido.MostrarMensagem("sigla"));
        }

        private void  AtualizarMaximoCaracteres()
        {
            txSigla.MaxLength = Partido.MaxCaracteres.Sigla;
        }
        
        private void btCadastar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Refresh();

            RecuperarDadosTextbox();

            if (this.partido.PossuiErros())
                AlternarFormErros();
            else
            {
                if (this.partido.Salvar())
                {
                    btLimpar_Click(sender, e);
                    Decorator.MessageBoxSuccess("Registro criado com sucesso!");
                    formVereadores.AtualizarPartidos();
                }
                else
                    Decorator.MessageBoxError(this.partido.MostrarMensagem("criar"));

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
             
        private void FormPartido_KeyDown(object sender, KeyEventArgs e)
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

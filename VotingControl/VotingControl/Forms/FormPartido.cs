using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace VotingControl
{
    public partial class FormPartido : Form
    {
        public FormPartido(FormVereadores formVereadores = null)
        {
            InitializeComponent();
            this.formVereadores = formVereadores;
        }

        FormVereadores formVereadores;

        private void FormPartido_Load(object sender, EventArgs e)
        {
            AtualizarMaximoCaracteres();
            partido = new Partido();
            
        }
       
        private Partido partido; 

        private void btCadastar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Refresh();

            RecuperarDadosTextbox();

            if (partido.PossuiErros())
                AlternarFormErros();
            else
            {
                if (partido.Salvar())
                {
                    btLimpar_Click(sender, e);
                    Decorator.MessageBoxSuccess("Registro criado com sucesso!");
                    formVereadores.Atualizar();
                }
                else
                    Decorator.MessageBoxError(partido.MostrarMensagem("criar"));

                Decorator.FocusOnFirstTextBox(pnContent.Controls);

            }
        }
        private void  AtualizarMaximoCaracteres()
        {
            txSigla.MaxLength = Partido.MaxCaracteres.Sigla;
        }
        private void RecuperarDadosTextbox()
        {
            partido.Sigla = txSigla.Text.ToUpper();
        }
        private void AlternarFormErros()
        {
            errorProvider1.SetError(txSigla, partido.MostrarMensagem("sigla"));
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

        private void FormPartido_FormClosed(object sender, FormClosedEventArgs e)
        {           
        }

       
        
       

       
    }
}

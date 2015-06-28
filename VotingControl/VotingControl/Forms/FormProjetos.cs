using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingControl
{
    public partial class FormProjetos : Form
    {
        public FormProjetos()
        {
            InitializeComponent();
        }

        
        private void FormProjetos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingcontrolDataSet.sessoes' table. You can move, or remove it, as needed.
            this.sessoesTableAdapter.Fill(this.votingcontrolDataSet.sessoes);
            AlteraMaxCaracteres();
            projeto = new Projeto();
            // TODO: This line of code loads data into the 'votingcontrolDataSet.vereadores' table. You can move, or remove it, as needed.
            this.vereadoresTableAdapter.Fill(this.votingcontrolDataSet.vereadores);
        }

        private Projeto projeto;

        private void OpenForm(Form form)
        {
            form.Show();
        }
        private void btCadastrarVereador_Click(object sender, EventArgs e)
        {
            OpenForm(new FormVereadores());
        }

        private void cbVereadores_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoComplete =
               Decorator.AutoCompleteFor(cbVereadores.Text, this.votingcontrolDataSet.vereadores.Copy());

            if (cbVereadores.AutoCompleteCustomSource.Count != autoComplete.Count)
                cbVereadores.AutoCompleteCustomSource = autoComplete;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

            Decorator.ClearControls(pnContent.Controls);
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }      

        private void btCadastar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Refresh();

            RecuperarDadosTextBox();

            if (projeto.PossuiErros())
                AlternarFormsErros();
            else
            {
                AlternarFormsErros();

                if (projeto.Salvar())
                {
                    btLimpar_Click(sender, e);
                    Decorator.MessageBoxSuccess("Registro realizado com sucesso!");
                }
                else
                    Decorator.MessageBoxError(projeto.MostrarMensagem("criar"));

                Decorator.FocusOnFirstTextBox(pnContent.Controls);
            }
            
        }
        private void AlteraMaxCaracteres()
        {
            txTitulo.MaxLength = Projeto.MaxCaracteres.Titulo;
        }
        private void AlternarFormsErros()
        {
            errorProvider1.SetError(txTitulo, projeto.MostrarMensagem("titulo"));
            errorProvider1.SetError(cbVereadores, projeto.MostrarMensagem("vereadores"));
            errorProvider1.SetError(cbSessao, projeto.MostrarMensagem("sessao"));
        }
        private void RecuperarDadosTextBox()
        {
            projeto.Titulo = txTitulo.Text;
            projeto.VereadorId = Convert.ToInt32(cbVereadores.SelectedValue);
        }
        private void btAbrirLista_Click(object sender, EventArgs e)
        {
        }

        private void cbSessao_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoComplete =
              Decorator.AutoCompleteFor(cbSessao.Text, this.votingcontrolDataSet.sessoes.Copy());

            if (cbSessao.AutoCompleteCustomSource.Count != autoComplete.Count)
                cbSessao.AutoCompleteCustomSource = autoComplete;
        }

        private void FormProjetos_KeyDown(object sender, KeyEventArgs e)
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

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
    public partial class FormCadeira : Form
    {
        private Cadeira cadeira;

        public FormCadeira()
        {
            InitializeComponent();
        }

        private void FormCadeira_Load(object sender, EventArgs e)
        {
            this.vereadoresTableAdapter.Fill(this.votingcontrolDataSet.vereadores);
            AtualizarMaximoCaracteres();

            this.cadeira = new Cadeira();
        }

        private void RecuperarDadosTextBox()
        {
            this.cadeira.Identificador = txIdentificador.Text;
            this.cadeira.VereadorId = Convert.ToInt32(cbVereadores.SelectedValue);
        }

        private void AlternarFormErros()
        {
            errorProvider.SetError(txIdentificador, this.cadeira.ShowMessage("identificador"));
            errorProvider.SetError(cbVereadores, this.cadeira.ShowMessage("vereador_id"));
        }

        private void AtualizarMaximoCaracteres()
        {
            txIdentificador.MaxLength = Cadeira.MaxCaracteres.Identificador;
        }
        
        private void btCadastar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            this.Refresh();

            RecuperarDadosTextBox();

            if (this.cadeira.Save())
            {
                btLimpar_Click(sender, e);
                Decorator.MessageBoxSuccess("Registro criado com sucesso!");
            }
            else if (this.cadeira.HasErrorsOn("criar"))
                Decorator.MessageBoxError(this.cadeira.ShowMessage("criar"));

            AlternarFormErros();
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Decorator.ClearControls(pnContent.Controls);
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }

        private void cbVereadores_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoComplete =
                Decorator.AutoCompleteFor(cbVereadores.Text, this.votingcontrolDataSet.vereadores.Copy());
            
            if (cbVereadores.AutoCompleteCustomSource.Count != autoComplete.Count)
                cbVereadores.AutoCompleteCustomSource = autoComplete;
        }

        private void btCadastrarVereador_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormVereadores());
        }

        private void btAbrirLista_Click(object sender, EventArgs e)
        {
        }
    }
}

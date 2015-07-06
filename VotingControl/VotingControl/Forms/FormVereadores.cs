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
    public partial class FormVereadores : Form
    {
        Vereador vereador;

        public FormVereadores()
        {
            InitializeComponent();
        }

        private void FormVereadores_Load(object sender, EventArgs e)
        {
            AtualizarPartidos();
            AtualizarMaximoCaracteres();
            openFileDialog.Title = "Escolher Imagem";
            cbSexo.Items.AddRange(SexosHuman.Tipos);
            txNome.Focus();

            this.vereador = new Vereador();
        }

        public void AtualizarPartidos()
        {
            this.partidosTableAdapter.Fill(this.votingcontrolDataSet.partidos);
        }

        private void RecuperarDadosTextBox()
        {
            this.vereador.Nome = txNome.Text;
            this.vereador.Sexo = SexosHuman.EnumFor(cbSexo.Text);
            this.vereador.Cpf = mtxCPF.Text;
            this.vereador.PartidoId = (int)cbPartido.SelectedValue;
            this.vereador.Foto = txCaminhoImg.Text;
        }

        private void AlternarFormErros()
        {
            errorProvider.SetError(txNome, this.vereador.MostrarMensagem("nome"));
            errorProvider.SetError(cbSexo, this.vereador.MostrarMensagem("sexo"));
            errorProvider.SetError(mtxCPF, this.vereador.MostrarMensagem("cpf"));
            errorProvider.SetError(cbPartido, this.vereador.MostrarMensagem("partido"));
            errorProvider.SetError(txCaminhoImg, this.vereador.MostrarMensagem("foto"));
        }

        private void AtualizarMaximoCaracteres()
        {
            txNome.MaxLength = Vereador.MaxCaracteres.Nome;
        }

        private void btCadastrarPartido_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormPartido(this), true);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Decorator.ClearControls(pnContent.Controls);
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }

        private void btAbrirLista_Click(object sender, EventArgs e)
        {
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            this.Refresh();

            RecuperarDadosTextBox();

            if (this.vereador.Salvar())
            {
                btLimpar_Click(sender, e);
                Decorator.MessageBoxSuccess("Registro criado com sucesso!");
            }
            else if (this.vereador.PossuiErrosEm("criar"))
                Decorator.MessageBoxError(this.vereador.MostrarMensagem("criar"));

            AlternarFormErros();
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
            this.Cursor = Cursors.Default;
        }

        private void FormVereadores_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btAbrirLista_Click(sender, e);
                    break;
            }
        }

        private void btEscolherImagem_Click(object sender, EventArgs e)
        {
            DialogResult escolherImagem = openFileDialog.ShowDialog();

            if (escolherImagem == DialogResult.OK)
            {
                txCaminhoImg.Text = openFileDialog.FileName;
                pbVereador.Image = Image.FromFile(txCaminhoImg.Text);
            }
        }
    }
}

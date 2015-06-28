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
        public FormVereadores()
        {
            InitializeComponent();
        }

        private void FormVereadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingcontrolDataSet.partidos' table. You can move, or remove it, as needed.
            this.partidosTableAdapter.Fill(this.votingcontrolDataSet.partidos);
            vereador = new Vereador();
            txNome.Focus();
            cbSexo.Items.AddRange(SexosHuman.Tipos);
        }

        Vereador vereador;

        private void OpenForm(Form form)
        {
            form.Show();
        }
               
        private void btCadastrarPartido_Click(object sender, EventArgs e)
        {
            Decorator.openForm(new FormPartido(this), true);
        }
        public void Atualizar()
        {
            FormVereadores_Load(null, null);
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

            RecuperarDadosForm();

            if (vereador.PossuiErros())
               AlternarFormErros();
            else
            {
                if (vereador.Salvar())
                {
                    AlternarFormErros();
                    btLimpar_Click(sender, e);
                    Decorator.MessageBoxSuccess("Registro gravado com sucesso.");
                }
                else
                    Decorator.MessageBoxError(vereador.MostrarMensagem("criar"));
            }

            Decorator.FocusOnFirstTextBox(pnContent.Controls);
            this.Cursor = Cursors.Default;
        }
        private void RecuperarDadosForm()
        {
            vereador.Nome = txNome.Text;
            vereador.Sexo = SexosHuman.EnumFor(cbSexo.Text);
            vereador.Cpf = mtxCPF.Text;
            vereador.PartidoId = (int)cbPartido.SelectedValue;
            vereador.Foto = txCaminhoImg.Text;

        }   
        private void AlternarFormErros()
        {
            errorProvider.SetError(txNome, vereador.MostrarMensagem("nome"));
            errorProvider.SetError(cbSexo, vereador.MostrarMensagem("sexo"));
            errorProvider.SetError(mtxCPF, vereador.MostrarMensagem("cpf"));
            errorProvider.SetError(cbPartido, vereador.MostrarMensagem("partido"));
            errorProvider.SetError(txCaminhoImg, vereador.MostrarMensagem("foto"));
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Escolher Imagem";
            DialogResult escolherImagem = openFileDialog1.ShowDialog(); // abre a caixa de dialogo onde podera ser pegado o path da imagem.
            if (escolherImagem == DialogResult.OK)
            {
                txCaminhoImg.Text = openFileDialog1.FileName;
                Image imagem = Image.FromFile(txCaminhoImg.Text);
                pbVereador.Image = imagem;
            }

        }
    }
}

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
    public partial class FormSessao : Form
    {
        public FormSessao()
        {
            InitializeComponent();
            //MessageBox.Show(TiposDeSessaoHuman.TextFor(TiposDeSessao.Ordinaria));
            cbTipo.Items.AddRange(TiposDeSessaoHuman.Tipos);
            sessao = new Sessao();
        }

        Sessao sessao;

        private void OpenForm(Form form)
        {
            form.Show();
        }
        private void FormSessao_Load(object sender, EventArgs e)
        {
            AtualizarMaxFormCaracteres();
        }

        private void RecuperarDadosTextBox()
        {
            //Recupera os dados da textbox
            sessao.Titulo = txTituloSessao.Text;
            sessao.Tipo = TiposDeSessaoHuman.EnumFor(cbTipo.Text);
            sessao.Fim = dtpFimSessao.Value;
            sessao.Inicio = dtpInicioSessao.Value;
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.AppStarting; //Altera o cursor do mause enquanto estiver no metodo                    
            this.Refresh(); //Mostra o cursor alterado na tela enquanto estiver executanto o metodo

            RecuperarDadosTextBox();

            if (sessao.PossuiErros())
                AlternarFormErros();
            else
            {
                AlternarFormErros();

                if (sessao.Salvar())
                {
                    btLimpar_Click(sender, e);
                    Decorator.MessageBoxSuccess("Registro criado com sucesso!");
                }
                else
                    Decorator.MessageBoxError(sessao.MostrarMensagem("criar"));
            }
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }  
        private void AtualizarMaxFormCaracteres()
        {
            txTituloSessao.MaxLength = Sessao.MaxCaracteres.Titulo;
        }
        private void AlternarFormErros()
        {            
            errorProvider.SetError(txTituloSessao, sessao.MostrarMensagem("titulo"));
            errorProvider.SetError(cbTipo, sessao.MostrarMensagem("tipo"));
            errorProvider.SetError(dtpInicioSessao, sessao.MostrarMensagem("inicio"));
            errorProvider.SetError(dtpFimSessao, sessao.MostrarMensagem("fim"));
        }
       
        private void btLimpar_Click(object sender, EventArgs e)
        {
            Decorator.ClearControls(pnContent.Controls);
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }

        private void btAbrirLista_Click(object sender, EventArgs e)
        {

        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            OpenForm(new FormProjetos());
        }

        private void FormSessao_KeyDown(object sender, KeyEventArgs e)
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

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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (new Administrador().Login(txUsuario.Text, txSenha.Text))
            {
                new FormPrincipal(txUsuario.Text).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválido... \n Por favor tente novamente.",
                "Erro ao realizar acesso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Decorator.ClearControls(pnContent.Controls);
                Decorator.FocusOnFirstTextBox(pnContent.Controls);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            DialogResult continuar = MessageBox.Show("Deseja realmente sair? ",
               "Saindo do sistema ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (continuar == DialogResult.OK)
                this.Close();    
        }
    }
}

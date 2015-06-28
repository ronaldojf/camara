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
using System.IO;

namespace VotingControl
{
    public partial class FormPrincipal : Form
    {
        Administrador administrador;

        public FormPrincipal(Administrador administrador)
        {
            InitializeComponent();
            
            this.administrador = administrador;
            lbUsuario.Text = this.administrador.Usuario;
        }

        public FormPrincipal(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lbData.Text = Convert.ToString(DateTime.Now);
            lbData.ForeColor = System.Drawing.Color.DarkBlue;
            lbUsuario.ForeColor = System.Drawing.Color.DarkBlue;
        }

        private void sessoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormSessao(), this);
        }
        
        private void vereadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormVereadores(), this);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja fechar o sistema?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja fechar o sistema ?", "Aviso",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
                Application.ExitThread();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormProjetos(), this);
        }

        private void suplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormSuplentes(), this);
        }

        private void cadeirasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormCadeira(), this);
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormPartido(), this);
        }

        private void manualDeAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Path.GetFullPath(@"..\..\Ajuda\Ajuda Voting Control.chm"));
        }
    }
}

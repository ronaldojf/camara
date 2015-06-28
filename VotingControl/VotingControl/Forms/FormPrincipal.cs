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
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            DateTime DataInicial = DateTime.Now;
            lbData.Text = Convert.ToString(DataInicial);

            lbData.ForeColor = System.Drawing.Color.DarkBlue;
            lbUsuario.ForeColor = System.Drawing.Color.DarkBlue;

        }

        public FormPrincipal(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void sessoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.openForm(new FormSessao(), this);
        }
        
        private void vereadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.openForm(new FormVereadores(), this);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja fechar o sistema ?", "Aviso",
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
            else
            {
            }
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.openForm(new FormProjetos(), this);
        }

        private void suplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.openForm(new FormSuplentes(), this);
        }

        private void cadeirasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.openForm(new FormCadeira(), this);
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decorator.openForm(new FormPartido(), this);
        }

        private void manualDeAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostra o arquivo de ajuda, Path.GetFullPath("Diretorio") retorna o caminho do executavel e passa o resto do caminho do arquivo de ajuda;
            Help.ShowHelp(this, Path.GetFullPath(@"..\..\Ajuda\Ajuda Voting Control.chm")); //@ Permite colocar apenas \ ao invez de \\  e ..\..\ volta duas pastas a partir do diretorio do executavel.
        }
    }
}

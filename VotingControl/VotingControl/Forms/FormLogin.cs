﻿using System;
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
        Administrador administrador;

        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = txUsuario;
            this.administrador = new Administrador();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (this.administrador.Login(txUsuario.Text, txSenha.Text))
            {
                Program.FormPrincipal = new FormPrincipal(txUsuario.Text);
                Program.FormPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválido... \n Por favor tente novamente.",
                "Erro ao realizar acesso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txSenha.Clear();
                txSenha.Focus();
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

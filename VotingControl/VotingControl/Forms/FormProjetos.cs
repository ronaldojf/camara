﻿using System;
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
        private Projeto projeto;

        public FormProjetos()
        {
            InitializeComponent();
        }

        public void RefreshVereadores()
        {
            this.vereadoresTableAdapter.Fill(this.votingcontrolDataSet.vereadores);
        }
        
        private void FormProjetos_Load(object sender, EventArgs e)
        {
            this.sessoesTableAdapter.Fill(this.votingcontrolDataSet.sessoes);
            RefreshVereadores();
            this.ActiveControl = txTitulo;
            AtualizarMaximoCaracteres();

            this.projeto = new Projeto();
        }

        private void AlternarFormErros()
        {
            errorProvider.SetError(txTitulo, this.projeto.ShowMessage("titulo"));
            errorProvider.SetError(cbVereadores, this.projeto.ShowMessage("vereador_id"));
            errorProvider.SetError(cbSessao, this.projeto.ShowMessage("sessao_id"));
        }

        private void RecuperarDadosTextBox()
        {
            this.projeto.Titulo = txTitulo.Text;
            this.projeto.VereadorId = Convert.ToInt32(cbVereadores.SelectedValue);
        }

        private void AtualizarMaximoCaracteres()
        {
            txTitulo.MaxLength = Projeto.MaxCaracteres.Titulo;
        }

        private void btCadastrarVereador_Click(object sender, EventArgs e)
        {
            Decorator.OpenForm(new FormVereadores(this));
        }

        private void cbVereadores_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoComplete =
               Decorator.AutoCompleteFor(cbVereadores.Text, this.votingcontrolDataSet.vereadores.Copy());

            if (cbVereadores.AutoCompleteCustomSource.Count != autoComplete.Count)
                cbVereadores.AutoCompleteCustomSource = autoComplete;
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

            if (this.projeto.Save())
            {
                btLimpar_Click(sender, e);
                Decorator.MessageBoxSuccess("Registro criado com sucesso!");
            }
            else if (this.projeto.HasErrorsOn("criar"))
                Decorator.MessageBoxError(this.projeto.ShowMessage("criar"));

            AlternarFormErros();
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
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
                case Keys.F5:
                    btAbrirLista_Click(sender, e);
                    break;
            }
        }
    }
}

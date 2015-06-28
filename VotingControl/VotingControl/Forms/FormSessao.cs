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
    public partial class FormSessao : Form
    {
        Sessao sessao;
        
        public FormSessao()
        {
            InitializeComponent();
            AtualizarMaximoCaracteres();
            cbTipo.Items.AddRange(TiposDeSessaoHuman.Tipos);

            this.sessao = new Sessao();
        }

        private void RecuperarDadosTextBox()
        {
            this.sessao.Titulo = txTituloSessao.Text;
            this.sessao.Tipo = TiposDeSessaoHuman.EnumFor(cbTipo.Text);
            this.sessao.Fim = dtpFimSessao.Value;
            this.sessao.Inicio = dtpInicioSessao.Value;
        }

        private void AlternarFormErros()
        {
            errorProvider.SetError(txTituloSessao, this.sessao.MostrarMensagem("titulo"));
            errorProvider.SetError(cbTipo, this.sessao.MostrarMensagem("tipo"));
            errorProvider.SetError(dtpInicioSessao, this.sessao.MostrarMensagem("inicio"));
            errorProvider.SetError(dtpFimSessao, this.sessao.MostrarMensagem("fim"));
        }

        private void AtualizarMaximoCaracteres()
        {
            txTituloSessao.MaxLength = Sessao.MaxCaracteres.Titulo;
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.AppStarting;
            this.Refresh();

            RecuperarDadosTextBox();

            if (this.sessao.PossuiErros())
                AlternarFormErros();
            else
            {
                AlternarFormErros();

                if (this.sessao.Salvar())
                {
                    btLimpar_Click(sender, e);
                    Decorator.MessageBoxSuccess("Registro criado com sucesso!");
                }
                else
                    Decorator.MessageBoxError(this.sessao.MostrarMensagem("criar"));
            }

            Decorator.FocusOnFirstTextBox(pnContent.Controls);
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
            Decorator.OpenForm(new FormProjetos());
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

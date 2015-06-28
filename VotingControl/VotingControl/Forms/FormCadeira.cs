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
        public FormCadeira()
        {
            InitializeComponent();
            cadeira = new Cadeira(); //Inicializa o objeto cadeira
        }

        private Cadeira cadeira;

        private void FormCadeira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingcontrolDataSet.vereadores' table. You can move, or remove it, as needed.
            this.vereadoresTableAdapter.Fill(this.votingcontrolDataSet.vereadores);

            AtualizarMaximoCaracteres(); // Chama a função que define o tamanho maximo de caracteres ao iniciar o form
            AlternarFormErros(); //Verifica se possui erros e caso possua os mostra e limpa os campos
        }
        
        //atribuir erro geral
        private void btCadastar_Click(object sender, EventArgs e)
        {
            //Muda o cursor do mause quando entrar no metodo
            Cursor.Current = Cursors.AppStarting;
            this.Refresh(); // Mostra o cursor, pois atualiza a tela

            RecuperarDadosTextBox();
            
            if (cadeira.PossuiErros()) //Verifica se possui erro nos atributos da cadeira
                AlternarFormErros();
            else
            {
                AlternarFormErros();

                if (cadeira.Salvar()) //Caso não tenha nenhum erro grava no banco de dados
                {
                    btLimpar_Click(sender, e); //Limpa
                    Decorator.MessageBoxSuccess("Registro criado com sucesso!"); //Messagem 
                }
                else
                    Decorator.MessageBoxError(cadeira.MostrarMensagem("criar")); //Erros de conexão ou Sql

                Decorator.FocusOnFirstTextBox(pnContent.Controls); //Foca no primeiro textBox
                                
            }

           
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Decorator.ClearControls(pnContent.Controls);
            Decorator.FocusOnFirstTextBox(pnContent.Controls);
        }

        private void RecuperarDadosTextBox()
        {            
            //Recupera os dados da textbox
            cadeira.Identificador = txIdentificador.Text;
            cadeira.VereadorId = Convert.ToInt32(cbVereadores.SelectedValue);
        }

        private void AlternarFormErros()
        {
            //Mostra o erro setando o errorProvaider ,e limpa o form caso tenha erro nos atributos 
            errorProvider.SetError(txIdentificador, cadeira.MostrarMensagem("identificador"));
            errorProvider.SetError(cbVereadores, cadeira.MostrarMensagem("vereador_id"));
        }

        private void AtualizarMaximoCaracteres()
        {
            //Define o tamanho maximo de caracteres para o identificador
            txIdentificador.MaxLength = Cadeira.MaxCaracteres.Identificador;
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
            Decorator.openForm(new FormVereadores());
        }
    }
}

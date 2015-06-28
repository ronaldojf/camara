namespace VotingControl
{
    partial class FormVereadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVereadores));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.txCaminhoImg = new System.Windows.Forms.TextBox();
            this.btCadastrarPartido = new System.Windows.Forms.Button();
            this.btEscolherImagem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbVereador = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPartido = new System.Windows.Forms.ComboBox();
            this.partidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingcontrolDataSet = new VotingControl.votingcontrolDataSet();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAbrirLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.partidosTableAdapter = new VotingControl.votingcontrolDataSetTableAdapters.partidosTableAdapter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVereador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingcontrolDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btCadastar);
            this.panel3.Controls.Add(this.btLimpar);
            this.panel3.Location = new System.Drawing.Point(4, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(572, 77);
            this.panel3.TabIndex = 25;
            // 
            // btCadastar
            // 
            this.btCadastar.BackgroundImage = global::VotingControl.Properties.Resources._7881_32x32;
            this.btCadastar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCadastar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btCadastar.Location = new System.Drawing.Point(303, 27);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(232, 41);
            this.btCadastar.TabIndex = 9;
            this.btCadastar.Text = "Gravar";
            this.btCadastar.UseVisualStyleBackColor = true;
            this.btCadastar.Click += new System.EventHandler(this.btCadastar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackgroundImage = global::VotingControl.Properties.Resources._782_32x32;
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btLimpar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(37, 27);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(232, 41);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContent.Controls.Add(this.txCaminhoImg);
            this.pnContent.Controls.Add(this.btCadastrarPartido);
            this.pnContent.Controls.Add(this.btEscolherImagem);
            this.pnContent.Controls.Add(this.groupBox1);
            this.pnContent.Controls.Add(this.label3);
            this.pnContent.Controls.Add(this.cbPartido);
            this.pnContent.Controls.Add(this.cbSexo);
            this.pnContent.Controls.Add(this.label2);
            this.pnContent.Controls.Add(this.mtxCPF);
            this.pnContent.Controls.Add(this.label4);
            this.pnContent.Controls.Add(this.txNome);
            this.pnContent.Controls.Add(this.label7);
            this.pnContent.Location = new System.Drawing.Point(4, 73);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(572, 261);
            this.pnContent.TabIndex = 24;
            // 
            // txCaminhoImg
            // 
            this.txCaminhoImg.Enabled = false;
            this.txCaminhoImg.Location = new System.Drawing.Point(376, 216);
            this.txCaminhoImg.Name = "txCaminhoImg";
            this.txCaminhoImg.Size = new System.Drawing.Size(159, 20);
            this.txCaminhoImg.TabIndex = 7;
            // 
            // btCadastrarPartido
            // 
            this.btCadastrarPartido.BackgroundImage = global::VotingControl.Properties.Resources._838_32x32;
            this.btCadastrarPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadastrarPartido.Location = new System.Drawing.Point(204, 215);
            this.btCadastrarPartido.Name = "btCadastrarPartido";
            this.btCadastrarPartido.Size = new System.Drawing.Size(28, 21);
            this.btCadastrarPartido.TabIndex = 4;
            this.btCadastrarPartido.UseVisualStyleBackColor = true;
            this.btCadastrarPartido.Click += new System.EventHandler(this.btCadastrarPartido_Click);
            // 
            // btEscolherImagem
            // 
            this.btEscolherImagem.BackgroundImage = global::VotingControl.Properties.Resources._11252_32x32;
            this.btEscolherImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btEscolherImagem.Font = new System.Drawing.Font("Corbel", 9F);
            this.btEscolherImagem.Location = new System.Drawing.Point(376, 176);
            this.btEscolherImagem.Name = "btEscolherImagem";
            this.btEscolherImagem.Size = new System.Drawing.Size(159, 38);
            this.btEscolherImagem.TabIndex = 6;
            this.btEscolherImagem.Text = "      Escolher Imagem...";
            this.btEscolherImagem.UseVisualStyleBackColor = true;
            this.btEscolherImagem.Click += new System.EventHandler(this.btEscolherImagem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbVereador);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(376, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 150);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto:";
            // 
            // pbVereador
            // 
            this.pbVereador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbVereador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVereador.Location = new System.Drawing.Point(8, 26);
            this.pbVereador.Name = "pbVereador";
            this.pbVereador.Size = new System.Drawing.Size(145, 119);
            this.pbVereador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVereador.TabIndex = 0;
            this.pbVereador.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Partido:";
            // 
            // cbPartido
            // 
            this.cbPartido.DataSource = this.partidosBindingSource;
            this.cbPartido.DisplayMember = "sigla";
            this.cbPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartido.FormattingEnabled = true;
            this.cbPartido.Location = new System.Drawing.Point(238, 215);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(110, 21);
            this.cbPartido.TabIndex = 5;
            this.cbPartido.ValueMember = "id";
            // 
            // partidosBindingSource
            // 
            this.partidosBindingSource.DataMember = "partidos";
            this.partidosBindingSource.DataSource = this.votingcontrolDataSet;
            // 
            // votingcontrolDataSet
            // 
            this.votingcontrolDataSet.DataSetName = "votingcontrolDataSet";
            this.votingcontrolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(37, 215);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(149, 21);
            this.cbSexo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sexo:";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(37, 131);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(311, 20);
            this.mtxCPF.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "CPF:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(37, 46);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(311, 20);
            this.txNome.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btAbrirLista);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 68);
            this.panel1.TabIndex = 23;
            // 
            // btAbrirLista
            // 
            this.btAbrirLista.BackgroundImage = global::VotingControl.Properties.Resources.alterar;
            this.btAbrirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbrirLista.Location = new System.Drawing.Point(460, 9);
            this.btAbrirLista.Name = "btAbrirLista";
            this.btAbrirLista.Size = new System.Drawing.Size(75, 50);
            this.btAbrirLista.TabIndex = 10;
            this.btAbrirLista.UseVisualStyleBackColor = true;
            this.btAbrirLista.Click += new System.EventHandler(this.btAbrirLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Vereadores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VotingControl.Properties.Resources.funcionario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(37, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // partidosTableAdapter
            // 
            this.partidosTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormVereadores
            // 
            this.AcceptButton = this.btCadastar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.btLimpar;
            this.ClientSize = new System.Drawing.Size(579, 418);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVereadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vereadores";
            this.Load += new System.EventHandler(this.FormVereadores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVereadores_KeyDown);
            this.panel3.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVereador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingcontrolDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPartido;
        private System.Windows.Forms.Button btEscolherImagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbVereador;
        private System.Windows.Forms.Button btAbrirLista;
        private System.Windows.Forms.Button btCadastrarPartido;
        private votingcontrolDataSet votingcontrolDataSet;
        private System.Windows.Forms.BindingSource partidosBindingSource;
        private votingcontrolDataSetTableAdapters.partidosTableAdapter partidosTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txCaminhoImg;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.btCadastrarPartido = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txCaminhoImg = new System.Windows.Forms.TextBox();
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
            this.panel3.Location = new System.Drawing.Point(4, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 77);
            this.panel3.TabIndex = 25;
            // 
            // btCadastar
            // 
            this.btCadastar.BackgroundImage = global::VotingControl.Properties.Resources._7881_32x32;
            this.btCadastar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCadastar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btCadastar.Location = new System.Drawing.Point(504, 20);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(214, 41);
            this.btCadastar.TabIndex = 4;
            this.btCadastar.Text = "Gravar";
            this.btCadastar.UseVisualStyleBackColor = true;
            this.btCadastar.Click += new System.EventHandler(this.btCadastar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackgroundImage = global::VotingControl.Properties.Resources._782_32x32;
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(262, 20);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(214, 41);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContent.Controls.Add(this.txCaminhoImg);
            this.pnContent.Controls.Add(this.btCadastrarPartido);
            this.pnContent.Controls.Add(this.button1);
            this.pnContent.Controls.Add(this.groupBox1);
            this.pnContent.Controls.Add(this.label3);
            this.pnContent.Controls.Add(this.cbPartido);
            this.pnContent.Controls.Add(this.cbSexo);
            this.pnContent.Controls.Add(this.label2);
            this.pnContent.Controls.Add(this.mtxCPF);
            this.pnContent.Controls.Add(this.label4);
            this.pnContent.Controls.Add(this.txNome);
            this.pnContent.Controls.Add(this.label7);
            this.pnContent.Location = new System.Drawing.Point(4, 77);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(740, 287);
            this.pnContent.TabIndex = 24;
            // 
            // btCadastrarPartido
            // 
            this.btCadastrarPartido.BackgroundImage = global::VotingControl.Properties.Resources._838_32x32;
            this.btCadastrarPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadastrarPartido.Location = new System.Drawing.Point(20, 182);
            this.btCadastrarPartido.Name = "btCadastrarPartido";
            this.btCadastrarPartido.Size = new System.Drawing.Size(33, 21);
            this.btCadastrarPartido.TabIndex = 26;
            this.btCadastrarPartido.UseVisualStyleBackColor = true;
            this.btCadastrarPartido.Click += new System.EventHandler(this.btCadastrarPartido_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::VotingControl.Properties.Resources._11252_32x32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "        Escoher Imagem...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbVereador);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(470, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 177);
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
            this.pbVereador.Size = new System.Drawing.Size(236, 145);
            this.pbVereador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVereador.TabIndex = 0;
            this.pbVereador.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 157);
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
            this.cbPartido.Location = new System.Drawing.Point(54, 182);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(138, 21);
            this.cbPartido.TabIndex = 23;
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
            this.cbSexo.Location = new System.Drawing.Point(20, 118);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(172, 21);
            this.cbSexo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sexo:";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(247, 119);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(184, 20);
            this.mtxCPF.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "CPF:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(20, 56);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(411, 20);
            this.txNome.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 30);
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
            this.panel1.Size = new System.Drawing.Size(740, 71);
            this.panel1.TabIndex = 23;
            // 
            // btAbrirLista
            // 
            this.btAbrirLista.BackgroundImage = global::VotingControl.Properties.Resources.alterar;
            this.btAbrirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbrirLista.Location = new System.Drawing.Point(639, 10);
            this.btAbrirLista.Name = "btAbrirLista";
            this.btAbrirLista.Size = new System.Drawing.Size(75, 50);
            this.btAbrirLista.TabIndex = 6;
            this.btAbrirLista.UseVisualStyleBackColor = true;
            this.btAbrirLista.Click += new System.EventHandler(this.btAbrirLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Vereadores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VotingControl.Properties.Resources.funcionario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // partidosTableAdapter
            // 
            this.partidosTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txCaminhoImg
            // 
            this.txCaminhoImg.Enabled = false;
            this.txCaminhoImg.Location = new System.Drawing.Point(478, 255);
            this.txCaminhoImg.Name = "txCaminhoImg";
            this.txCaminhoImg.Size = new System.Drawing.Size(236, 20);
            this.txCaminhoImg.TabIndex = 27;
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
            this.ClientSize = new System.Drawing.Size(749, 446);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbVereador;
        private System.Windows.Forms.Button btAbrirLista;
        private System.Windows.Forms.Button btCadastrarPartido;
        private votingcontrolDataSet votingcontrolDataSet;
        private System.Windows.Forms.BindingSource partidosBindingSource;
        private votingcontrolDataSetTableAdapters.partidosTableAdapter partidosTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txCaminhoImg;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
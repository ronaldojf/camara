namespace VotingControl
{
    partial class FormProjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjetos));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSessao = new System.Windows.Forms.ComboBox();
            this.sessoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingcontrolDataSet = new VotingControl.votingcontrolDataSet();
            this.btCadastrarVereador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVereadores = new System.Windows.Forms.ComboBox();
            this.vereadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAbrirLista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vereadoresTableAdapter = new VotingControl.votingcontrolDataSetTableAdapters.vereadoresTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sessoesTableAdapter = new VotingControl.votingcontrolDataSetTableAdapters.sessoesTableAdapter();
            this.panel3.SuspendLayout();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingcontrolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereadoresBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btCadastar);
            this.panel3.Controls.Add(this.btLimpar);
            this.panel3.Location = new System.Drawing.Point(2, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 62);
            this.panel3.TabIndex = 22;
            // 
            // btCadastar
            // 
            this.btCadastar.BackgroundImage = global::VotingControl.Properties.Resources._7881_32x32;
            this.btCadastar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCadastar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btCadastar.Location = new System.Drawing.Point(335, 15);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(289, 41);
            this.btCadastar.TabIndex = 5;
            this.btCadastar.Text = "Cadastrar";
            this.btCadastar.UseVisualStyleBackColor = true;
            this.btCadastar.Click += new System.EventHandler(this.btCadastar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackgroundImage = global::VotingControl.Properties.Resources._782_32x32;
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btLimpar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(23, 15);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(291, 41);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContent.Controls.Add(this.label3);
            this.pnContent.Controls.Add(this.cbSessao);
            this.pnContent.Controls.Add(this.btCadastrarVereador);
            this.pnContent.Controls.Add(this.label2);
            this.pnContent.Controls.Add(this.cbVereadores);
            this.pnContent.Controls.Add(this.txTitulo);
            this.pnContent.Controls.Add(this.label1);
            this.pnContent.Location = new System.Drawing.Point(2, 73);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(650, 132);
            this.pnContent.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sessão:";
            // 
            // cbSessao
            // 
            this.cbSessao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSessao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSessao.DataSource = this.sessoesBindingSource;
            this.cbSessao.DisplayMember = "titulo";
            this.cbSessao.FormattingEnabled = true;
            this.cbSessao.Location = new System.Drawing.Point(335, 93);
            this.cbSessao.Name = "cbSessao";
            this.cbSessao.Size = new System.Drawing.Size(289, 21);
            this.cbSessao.TabIndex = 3;
            this.cbSessao.ValueMember = "id";
            this.cbSessao.TextChanged += new System.EventHandler(this.cbSessao_TextChanged);
            // 
            // sessoesBindingSource
            // 
            this.sessoesBindingSource.DataMember = "sessoes";
            this.sessoesBindingSource.DataSource = this.votingcontrolDataSet;
            // 
            // votingcontrolDataSet
            // 
            this.votingcontrolDataSet.DataSetName = "votingcontrolDataSet";
            this.votingcontrolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btCadastrarVereador
            // 
            this.btCadastrarVereador.BackgroundImage = global::VotingControl.Properties.Resources._838_32x32;
            this.btCadastrarVereador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadastrarVereador.Location = new System.Drawing.Point(23, 94);
            this.btCadastrarVereador.Name = "btCadastrarVereador";
            this.btCadastrarVereador.Size = new System.Drawing.Size(33, 22);
            this.btCadastrarVereador.TabIndex = 1;
            this.btCadastrarVereador.UseVisualStyleBackColor = true;
            this.btCadastrarVereador.Click += new System.EventHandler(this.btCadastrarVereador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vereador:";
            // 
            // cbVereadores
            // 
            this.cbVereadores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVereadores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbVereadores.DataSource = this.vereadoresBindingSource;
            this.cbVereadores.DisplayMember = "nome";
            this.cbVereadores.FormattingEnabled = true;
            this.cbVereadores.Location = new System.Drawing.Point(62, 95);
            this.cbVereadores.Name = "cbVereadores";
            this.cbVereadores.Size = new System.Drawing.Size(252, 21);
            this.cbVereadores.TabIndex = 2;
            this.cbVereadores.ValueMember = "id";
            this.cbVereadores.TextChanged += new System.EventHandler(this.cbVereadores_TextChanged);
            // 
            // vereadoresBindingSource
            // 
            this.vereadoresBindingSource.DataMember = "vereadores";
            this.vereadoresBindingSource.DataSource = this.votingcontrolDataSet;
            // 
            // txTitulo
            // 
            this.txTitulo.Location = new System.Drawing.Point(23, 35);
            this.txTitulo.Name = "txTitulo";
            this.txTitulo.Size = new System.Drawing.Size(601, 20);
            this.txTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Título:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btAbrirLista);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 69);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btAbrirLista
            // 
            this.btAbrirLista.BackgroundImage = global::VotingControl.Properties.Resources.alterar;
            this.btAbrirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbrirLista.Location = new System.Drawing.Point(549, 8);
            this.btAbrirLista.Name = "btAbrirLista";
            this.btAbrirLista.Size = new System.Drawing.Size(75, 50);
            this.btAbrirLista.TabIndex = 6;
            this.btAbrirLista.UseVisualStyleBackColor = true;
            this.btAbrirLista.Click += new System.EventHandler(this.btAbrirLista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cadastro de Projetos";
            // 
            // vereadoresTableAdapter
            // 
            this.vereadoresTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // sessoesTableAdapter
            // 
            this.sessoesTableAdapter.ClearBeforeFill = true;
            // 
            // FormProjetos
            // 
            this.AcceptButton = this.btCadastar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.btLimpar;
            this.ClientSize = new System.Drawing.Size(654, 272);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Projetos";
            this.Load += new System.EventHandler(this.FormProjetos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProjetos_KeyDown);
            this.panel3.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingcontrolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereadoresBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVereadores;
        private System.Windows.Forms.TextBox txTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAbrirLista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCadastrarVereador;
        private votingcontrolDataSet votingcontrolDataSet;
        private System.Windows.Forms.BindingSource vereadoresBindingSource;
        private votingcontrolDataSetTableAdapters.vereadoresTableAdapter vereadoresTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSessao;
        private System.Windows.Forms.BindingSource sessoesBindingSource;
        private votingcontrolDataSetTableAdapters.sessoesTableAdapter sessoesTableAdapter;
    }
}
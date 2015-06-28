namespace VotingControl
{
    partial class FormCadeira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadeira));
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.btCadastrarVereador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVereadores = new System.Windows.Forms.ComboBox();
            this.vereadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingcontrolDataSet = new VotingControl.votingcontrolDataSet();
            this.txIdentificador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btAbrirLista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vereadoresTableAdapter = new VotingControl.votingcontrolDataSetTableAdapters.vereadoresTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnFooter.SuspendLayout();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vereadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingcontrolDataSet)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnFooter.Controls.Add(this.btCadastar);
            this.pnFooter.Controls.Add(this.btLimpar);
            this.pnFooter.Location = new System.Drawing.Point(4, 154);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(650, 73);
            this.pnFooter.TabIndex = 19;
            // 
            // btCadastar
            // 
            this.btCadastar.BackgroundImage = global::VotingControl.Properties.Resources._7881_32x32;
            this.btCadastar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCadastar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btCadastar.Location = new System.Drawing.Point(331, 23);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(292, 41);
            this.btCadastar.TabIndex = 4;
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
            this.btLimpar.Location = new System.Drawing.Point(23, 23);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(290, 41);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContent.Controls.Add(this.btCadastrarVereador);
            this.pnContent.Controls.Add(this.label2);
            this.pnContent.Controls.Add(this.cbVereadores);
            this.pnContent.Controls.Add(this.txIdentificador);
            this.pnContent.Controls.Add(this.label1);
            this.pnContent.Location = new System.Drawing.Point(4, 68);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(650, 84);
            this.pnContent.TabIndex = 17;
            // 
            // btCadastrarVereador
            // 
            this.btCadastrarVereador.BackgroundImage = global::VotingControl.Properties.Resources._838_32x32;
            this.btCadastrarVereador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadastrarVereador.Location = new System.Drawing.Point(331, 34);
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
            this.label2.Location = new System.Drawing.Point(327, 9);
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
            this.cbVereadores.Location = new System.Drawing.Point(370, 35);
            this.cbVereadores.Name = "cbVereadores";
            this.cbVereadores.Size = new System.Drawing.Size(253, 21);
            this.cbVereadores.TabIndex = 2;
            this.cbVereadores.ValueMember = "id";
            this.cbVereadores.TextChanged += new System.EventHandler(this.cbVereadores_TextChanged);
            // 
            // vereadoresBindingSource
            // 
            this.vereadoresBindingSource.DataMember = "vereadores";
            this.vereadoresBindingSource.DataSource = this.votingcontrolDataSet;
            // 
            // votingcontrolDataSet
            // 
            this.votingcontrolDataSet.DataSetName = "votingcontrolDataSet";
            this.votingcontrolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txIdentificador
            // 
            this.txIdentificador.Location = new System.Drawing.Point(22, 35);
            this.txIdentificador.Name = "txIdentificador";
            this.txIdentificador.Size = new System.Drawing.Size(291, 20);
            this.txIdentificador.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Identificador:";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnHeader.Controls.Add(this.btAbrirLista);
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.label5);
            this.pnHeader.Location = new System.Drawing.Point(4, 3);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(650, 63);
            this.pnHeader.TabIndex = 18;
            // 
            // btAbrirLista
            // 
            this.btAbrirLista.BackgroundImage = global::VotingControl.Properties.Resources.alterar;
            this.btAbrirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbrirLista.Location = new System.Drawing.Point(548, 8);
            this.btAbrirLista.Name = "btAbrirLista";
            this.btAbrirLista.Size = new System.Drawing.Size(75, 50);
            this.btAbrirLista.TabIndex = 3;
            this.btAbrirLista.UseVisualStyleBackColor = true;
            this.btAbrirLista.Click += new System.EventHandler(this.btAbrirLista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 8);
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
            this.label5.Location = new System.Drawing.Point(104, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cadastro de Cadeiras";
            // 
            // vereadoresTableAdapter
            // 
            this.vereadoresTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormCadeira
            // 
            this.AcceptButton = this.btCadastar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.btLimpar;
            this.ClientSize = new System.Drawing.Size(658, 230);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vereadoresBindingSource, "nome", true));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadeira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cadeiras";
            this.Load += new System.EventHandler(this.FormCadeira_Load);
            this.pnFooter.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vereadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingcontrolDataSet)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVereadores;
        private System.Windows.Forms.TextBox txIdentificador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btAbrirLista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private votingcontrolDataSet votingcontrolDataSet;
        private System.Windows.Forms.BindingSource vereadoresBindingSource;
        private votingcontrolDataSetTableAdapters.vereadoresTableAdapter vereadoresTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btCadastrarVereador;
    }
}
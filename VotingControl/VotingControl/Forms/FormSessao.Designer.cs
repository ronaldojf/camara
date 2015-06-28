namespace VotingControl
{
    partial class FormSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSessao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAbrirLista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.dtpFimSessao = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioSessao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txTituloSessao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btContinuar = new System.Windows.Forms.Button();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnContent.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btAbrirLista);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 63);
            this.panel1.TabIndex = 8;
            // 
            // btAbrirLista
            // 
            this.btAbrirLista.BackgroundImage = global::VotingControl.Properties.Resources.alterar;
            this.btAbrirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbrirLista.Location = new System.Drawing.Point(562, 6);
            this.btAbrirLista.Name = "btAbrirLista";
            this.btAbrirLista.Size = new System.Drawing.Size(75, 50);
            this.btAbrirLista.TabIndex = 3;
            this.btAbrirLista.UseVisualStyleBackColor = true;
            this.btAbrirLista.Click += new System.EventHandler(this.btAbrirLista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
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
            this.label5.Location = new System.Drawing.Point(88, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cadastro de Sessões";
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContent.Controls.Add(this.dtpFimSessao);
            this.pnContent.Controls.Add(this.dtpInicioSessao);
            this.pnContent.Controls.Add(this.label4);
            this.pnContent.Controls.Add(this.label2);
            this.pnContent.Controls.Add(this.cbTipo);
            this.pnContent.Controls.Add(this.label3);
            this.pnContent.Controls.Add(this.txTituloSessao);
            this.pnContent.Controls.Add(this.label1);
            this.pnContent.Location = new System.Drawing.Point(5, 68);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(650, 140);
            this.pnContent.TabIndex = 8;
            // 
            // dtpFimSessao
            // 
            this.dtpFimSessao.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpFimSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFimSessao.Location = new System.Drawing.Point(414, 92);
            this.dtpFimSessao.Name = "dtpFimSessao";
            this.dtpFimSessao.Size = new System.Drawing.Size(172, 20);
            this.dtpFimSessao.TabIndex = 15;
            // 
            // dtpInicioSessao
            // 
            this.dtpInicioSessao.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpInicioSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioSessao.Location = new System.Drawing.Point(208, 92);
            this.dtpInicioSessao.Name = "dtpInicioSessao";
            this.dtpInicioSessao.Size = new System.Drawing.Size(179, 20);
            this.dtpInicioSessao.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fim da Sessão: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(20, 91);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(160, 21);
            this.cbTipo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inìcio da Sessão: ";
            // 
            // txTituloSessao
            // 
            this.txTituloSessao.Location = new System.Drawing.Point(20, 35);
            this.txTituloSessao.Name = "txTituloSessao";
            this.txTituloSessao.Size = new System.Drawing.Size(591, 20);
            this.txTituloSessao.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Título:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btContinuar);
            this.panel3.Controls.Add(this.btCadastar);
            this.panel3.Controls.Add(this.btLimpar);
            this.panel3.Location = new System.Drawing.Point(5, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 77);
            this.panel3.TabIndex = 16;
            // 
            // btContinuar
            // 
            this.btContinuar.BackgroundImage = global::VotingControl.Properties.Resources._7859_32x32;
            this.btContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btContinuar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btContinuar.Location = new System.Drawing.Point(447, 23);
            this.btContinuar.Name = "btContinuar";
            this.btContinuar.Size = new System.Drawing.Size(190, 41);
            this.btContinuar.TabIndex = 5;
            this.btContinuar.Text = "Continuar";
            this.btContinuar.UseVisualStyleBackColor = true;
            this.btContinuar.Click += new System.EventHandler(this.btContinuar_Click);
            // 
            // btCadastar
            // 
            this.btCadastar.BackgroundImage = global::VotingControl.Properties.Resources._7881_32x32;
            this.btCadastar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCadastar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btCadastar.Location = new System.Drawing.Point(208, 23);
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
            this.btLimpar.Location = new System.Drawing.Point(7, 23);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(173, 41);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(660, 290);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Sessão";
            this.Load += new System.EventHandler(this.FormSessao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSessao_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.DateTimePicker dtpFimSessao;
        private System.Windows.Forms.DateTimePicker dtpInicioSessao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTituloSessao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btContinuar;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.Button btAbrirLista;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}
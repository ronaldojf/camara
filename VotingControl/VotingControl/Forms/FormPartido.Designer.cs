namespace VotingControl
{
    partial class FormPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartido));
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.txSigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btAbrirLista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnFooter.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnFooter.Controls.Add(this.btCadastar);
            this.pnFooter.Controls.Add(this.btLimpar);
            this.pnFooter.Location = new System.Drawing.Point(4, 154);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(455, 73);
            this.pnFooter.TabIndex = 22;
            // 
            // btCadastar
            // 
            this.btCadastar.BackgroundImage = global::VotingControl.Properties.Resources._7881_32x32;
            this.btCadastar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCadastar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btCadastar.Location = new System.Drawing.Point(238, 25);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(195, 41);
            this.btCadastar.TabIndex = 2;
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
            this.btLimpar.Location = new System.Drawing.Point(23, 25);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(197, 41);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContent.Controls.Add(this.txSigla);
            this.pnContent.Controls.Add(this.label2);
            this.pnContent.Location = new System.Drawing.Point(4, 68);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(455, 84);
            this.pnContent.TabIndex = 20;
            // 
            // txSigla
            // 
            this.txSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txSigla.Location = new System.Drawing.Point(77, 32);
            this.txSigla.Name = "txSigla";
            this.txSigla.Size = new System.Drawing.Size(356, 20);
            this.txSigla.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sigla:";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnHeader.Controls.Add(this.btAbrirLista);
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.label5);
            this.pnHeader.Location = new System.Drawing.Point(4, 3);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(455, 63);
            this.pnHeader.TabIndex = 21;
            // 
            // btAbrirLista
            // 
            this.btAbrirLista.BackgroundImage = global::VotingControl.Properties.Resources.alterar;
            this.btAbrirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbrirLista.Location = new System.Drawing.Point(358, 7);
            this.btAbrirLista.Name = "btAbrirLista";
            this.btAbrirLista.Size = new System.Drawing.Size(75, 50);
            this.btAbrirLista.TabIndex = 4;
            this.btAbrirLista.UseVisualStyleBackColor = true;
            this.btAbrirLista.Click += new System.EventHandler(this.btAbrirLista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 7);
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
            this.label5.Location = new System.Drawing.Point(105, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cadastro de Partidos";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormPartido
            // 
            this.AcceptButton = this.btCadastar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btLimpar;
            this.ClientSize = new System.Drawing.Size(462, 232);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Partidos";
            this.Load += new System.EventHandler(this.FormPartido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPartido_KeyDown);
            this.pnFooter.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.TextBox txSigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btAbrirLista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
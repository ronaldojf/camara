namespace VotingControl
{
    partial class FormSuplentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuplentes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAbrirLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnContent = new System.Windows.Forms.Panel();
            this.mtxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btAbrirLista);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 68);
            this.panel1.TabIndex = 0;
            // 
            // btAbrirLista
            // 
            this.btAbrirLista.BackgroundImage = global::VotingControl.Properties.Resources.alterar;
            this.btAbrirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbrirLista.Location = new System.Drawing.Point(551, 9);
            this.btAbrirLista.Name = "btAbrirLista";
            this.btAbrirLista.Size = new System.Drawing.Size(75, 50);
            this.btAbrirLista.TabIndex = 4;
            this.btAbrirLista.UseVisualStyleBackColor = true;
            this.btAbrirLista.Click += new System.EventHandler(this.btAbrirLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Suplentes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VotingControl.Properties.Resources._7777_64x64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btCadastar);
            this.panel3.Controls.Add(this.btLimpar);
            this.panel3.Location = new System.Drawing.Point(3, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 77);
            this.panel3.TabIndex = 22;
            // 
            // btCadastar
            // 
            this.btCadastar.BackgroundImage = global::VotingControl.Properties.Resources._7881_32x32;
            this.btCadastar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCadastar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btCadastar.Location = new System.Drawing.Point(337, 26);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(289, 41);
            this.btCadastar.TabIndex = 3;
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
            this.btLimpar.Location = new System.Drawing.Point(28, 26);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(288, 41);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContent.Controls.Add(this.mtxCpf);
            this.pnContent.Controls.Add(this.label4);
            this.pnContent.Controls.Add(this.txNome);
            this.pnContent.Controls.Add(this.label7);
            this.pnContent.Location = new System.Drawing.Point(3, 73);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(653, 85);
            this.pnContent.TabIndex = 9;
            // 
            // mtxCpf
            // 
            this.mtxCpf.Location = new System.Drawing.Point(337, 35);
            this.mtxCpf.Mask = "000.000.000-00";
            this.mtxCpf.Name = "mtxCpf";
            this.mtxCpf.Size = new System.Drawing.Size(289, 20);
            this.mtxCpf.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "CPF:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(28, 35);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(288, 20);
            this.txNome.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome:";
            // 
            // FormSuplentes
            // 
            this.AcceptButton = this.btCadastar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.btLimpar;
            this.ClientSize = new System.Drawing.Size(660, 239);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuplentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Suplentes";
            this.Load += new System.EventHandler(this.FormSuplentes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSuplentes_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAbrirLista;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.MaskedTextBox mtxCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label7;
    }
}
namespace VotingControl
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btEntrar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnFooter.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnFooter.Controls.Add(this.btEntrar);
            this.pnFooter.Controls.Add(this.btFechar);
            this.pnFooter.Location = new System.Drawing.Point(5, 154);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(425, 73);
            this.pnFooter.TabIndex = 25;
            // 
            // btEntrar
            // 
            this.btEntrar.BackgroundImage = global::VotingControl.Properties.Resources._7881_32x32;
            this.btEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btEntrar.Font = new System.Drawing.Font("Corbel", 12F);
            this.btEntrar.Location = new System.Drawing.Point(217, 21);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(177, 40);
            this.btEntrar.TabIndex = 3;
            this.btEntrar.Text = "  Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackgroundImage = global::VotingControl.Properties.Resources._818_32x32;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFechar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(29, 21);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(182, 40);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "  Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContent.Controls.Add(this.txUsuario);
            this.pnContent.Controls.Add(this.txSenha);
            this.pnContent.Controls.Add(this.label2);
            this.pnContent.Controls.Add(this.label1);
            this.pnContent.Location = new System.Drawing.Point(5, 68);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(425, 84);
            this.pnContent.TabIndex = 23;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(106, 19);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(288, 20);
            this.txUsuario.TabIndex = 0;
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(106, 49);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(288, 20);
            this.txSenha.TabIndex = 1;
            this.txSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuário:";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.label5);
            this.pnHeader.Location = new System.Drawing.Point(5, 3);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(425, 63);
            this.pnHeader.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingControl.Properties.Resources._1001_64x64;
            this.pictureBox1.Location = new System.Drawing.Point(29, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tela de Login";
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btFechar;
            this.ClientSize = new System.Drawing.Size(433, 227);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao Software";
            this.pnFooter.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
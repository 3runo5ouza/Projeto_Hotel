namespace Projeto_Hotel
{
    partial class fLogin
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
            this.o = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // o
            // 
            this.o.Location = new System.Drawing.Point(134, 76);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(75, 23);
            this.o.TabIndex = 2;
            this.o.Text = "Entrar";
            this.o.UseVisualStyleBackColor = true;
            this.o.Click += new System.EventHandler(this.Login_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(70, 50);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(139, 20);
            this.tbSenha.TabIndex = 1;
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyPress);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(70, 24);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(139, 20);
            this.tbUsuario.TabIndex = 0;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(21, 24);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(43, 13);
            this.lUsuario.TabIndex = 3;
            this.lUsuario.Text = "Usuário";
            // 
            // lSenha
            // 
            this.lSenha.AutoSize = true;
            this.lSenha.Location = new System.Drawing.Point(21, 53);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(38, 13);
            this.lSenha.TabIndex = 4;
            this.lSenha.Text = "Senha";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 112);
            this.Controls.Add(this.lSenha);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.o);
            this.Name = "fLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button o;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lSenha;
    }
}
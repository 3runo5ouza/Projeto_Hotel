namespace Projeto_Hotel
{
    partial class fCadastrarQuarto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxInternet = new System.Windows.Forms.CheckBox();
            this.cBoxFrigobar = new System.Windows.Forms.CheckBox();
            this.cBoxTv = new System.Windows.Forms.CheckBox();
            this.cBoxHidro = new System.Windows.Forms.CheckBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbAndar = new System.Windows.Forms.TextBox();
            this.cbTipoCama = new System.Windows.Forms.ComboBox();
            this.bOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Andar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de cama";
            // 
            // cBoxInternet
            // 
            this.cBoxInternet.AutoSize = true;
            this.cBoxInternet.Location = new System.Drawing.Point(15, 127);
            this.cBoxInternet.Name = "cBoxInternet";
            this.cBoxInternet.Size = new System.Drawing.Size(62, 17);
            this.cBoxInternet.TabIndex = 4;
            this.cBoxInternet.Text = "Internet";
            this.cBoxInternet.UseVisualStyleBackColor = true;
            // 
            // cBoxFrigobar
            // 
            this.cBoxFrigobar.AutoSize = true;
            this.cBoxFrigobar.Location = new System.Drawing.Point(15, 150);
            this.cBoxFrigobar.Name = "cBoxFrigobar";
            this.cBoxFrigobar.Size = new System.Drawing.Size(64, 17);
            this.cBoxFrigobar.TabIndex = 5;
            this.cBoxFrigobar.Text = "Frigobar";
            this.cBoxFrigobar.UseVisualStyleBackColor = true;
            // 
            // cBoxTv
            // 
            this.cBoxTv.AutoSize = true;
            this.cBoxTv.Location = new System.Drawing.Point(15, 173);
            this.cBoxTv.Name = "cBoxTv";
            this.cBoxTv.Size = new System.Drawing.Size(40, 17);
            this.cBoxTv.TabIndex = 6;
            this.cBoxTv.Text = "TV";
            this.cBoxTv.UseVisualStyleBackColor = true;
            // 
            // cBoxHidro
            // 
            this.cBoxHidro.AutoSize = true;
            this.cBoxHidro.Location = new System.Drawing.Point(15, 196);
            this.cBoxHidro.Name = "cBoxHidro";
            this.cBoxHidro.Size = new System.Drawing.Size(101, 17);
            this.cBoxHidro.TabIndex = 7;
            this.cBoxHidro.Text = "Hidromassagem";
            this.cBoxHidro.UseVisualStyleBackColor = true;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(93, 12);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(152, 20);
            this.tbNumero.TabIndex = 0;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(93, 64);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(152, 20);
            this.tbValor.TabIndex = 2;
            // 
            // tbAndar
            // 
            this.tbAndar.Location = new System.Drawing.Point(93, 38);
            this.tbAndar.Name = "tbAndar";
            this.tbAndar.Size = new System.Drawing.Size(152, 20);
            this.tbAndar.TabIndex = 1;
            // 
            // cbTipoCama
            // 
            this.cbTipoCama.FormattingEnabled = true;
            this.cbTipoCama.Items.AddRange(new object[] {
            "Casal",
            "Solteiro"});
            this.cbTipoCama.Location = new System.Drawing.Point(93, 90);
            this.cbTipoCama.Name = "cbTipoCama";
            this.cbTipoCama.Size = new System.Drawing.Size(121, 21);
            this.cbTipoCama.TabIndex = 3;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(246, 235);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 8;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // fCadastrarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 270);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.cbTipoCama);
            this.Controls.Add(this.tbAndar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.cBoxHidro);
            this.Controls.Add(this.cBoxTv);
            this.Controls.Add(this.cBoxFrigobar);
            this.Controls.Add(this.cBoxInternet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fCadastrarQuarto";
            this.Text = "fCadastrarQuarto";
            this.Load += new System.EventHandler(this.fCadastrarQuarto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cBoxInternet;
        private System.Windows.Forms.CheckBox cBoxFrigobar;
        private System.Windows.Forms.CheckBox cBoxTv;
        private System.Windows.Forms.CheckBox cBoxHidro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbAndar;
        private System.Windows.Forms.ComboBox cbTipoCama;
        private System.Windows.Forms.Button bOk;
    }
}
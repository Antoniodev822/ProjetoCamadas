namespace Projetodas3camadas.Ui
{
    partial class Form1
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
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.Link_senha = new System.Windows.Forms.LinkLabel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(246, 83);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(246, 209);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 1;
            this.lbl_senha.Text = "Senha";
            this.lbl_senha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(219, 121);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(100, 20);
            this.text_email.TabIndex = 2;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(219, 241);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(100, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // Link_senha
            // 
            this.Link_senha.AutoSize = true;
            this.Link_senha.Location = new System.Drawing.Point(216, 368);
            this.Link_senha.Name = "Link_senha";
            this.Link_senha.Size = new System.Drawing.Size(96, 13);
            this.Link_senha.TabIndex = 4;
            this.Link_senha.TabStop = true;
            this.Link_senha.Text = "Esqueceu a senha";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(236, 295);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.Link_senha);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_Email);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.LinkLabel Link_senha;
        private System.Windows.Forms.Button btn_entrar;
    }
}
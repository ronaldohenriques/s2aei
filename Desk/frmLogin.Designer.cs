namespace Desk
{
    partial class frmLogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLoginOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCredenciais = new System.Windows.Forms.Label();
            this.lblCliqueAqui = new System.Windows.Forms.LinkLabel();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe suas credenciais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(63, 42);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(263, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(63, 77);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // btnLoginOK
            // 
            this.btnLoginOK.Location = new System.Drawing.Point(182, 77);
            this.btnLoginOK.Name = "btnLoginOK";
            this.btnLoginOK.Size = new System.Drawing.Size(75, 23);
            this.btnLoginOK.TabIndex = 5;
            this.btnLoginOK.Text = "OK";
            this.btnLoginOK.UseVisualStyleBackColor = true;
            this.btnLoginOK.Click += new System.EventHandler(this.btnLoginOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblCredenciais
            // 
            this.lblCredenciais.AutoSize = true;
            this.lblCredenciais.Location = new System.Drawing.Point(60, 154);
            this.lblCredenciais.Name = "lblCredenciais";
            this.lblCredenciais.Size = new System.Drawing.Size(188, 13);
            this.lblCredenciais.TabIndex = 7;
            this.lblCredenciais.Text = "Você já tem suas credenciais? Se não";
            // 
            // lblCliqueAqui
            // 
            this.lblCliqueAqui.AutoSize = true;
            this.lblCliqueAqui.Location = new System.Drawing.Point(254, 154);
            this.lblCliqueAqui.Name = "lblCliqueAqui";
            this.lblCliqueAqui.Size = new System.Drawing.Size(62, 13);
            this.lblCliqueAqui.TabIndex = 8;
            this.lblCliqueAqui.TabStop = true;
            this.lblCliqueAqui.Text = "Clique aqui!";
            this.lblCliqueAqui.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCliqueAqui_LinkClicked);
            // 
            // cmbLogin
            // 
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Items.AddRange(new object[] {
            "Administrador",
            "Avaliador",
            "Professor"});
            this.cmbLogin.Location = new System.Drawing.Point(63, 106);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(121, 21);
            this.cmbLogin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Perfil:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLogin);
            this.Controls.Add(this.lblCliqueAqui);
            this.Controls.Add(this.lblCredenciais);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLoginOK);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Entrar no Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLoginOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCredenciais;
        private System.Windows.Forms.LinkLabel lblCliqueAqui;
        private System.Windows.Forms.ComboBox cmbLogin;
        private System.Windows.Forms.Label label5;
    }
}
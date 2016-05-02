namespace Desk
{
    partial class frmAtivacoes
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
            this.txtProfNome = new System.Windows.Forms.TextBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.rdbRecusado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProfFirst = new System.Windows.Forms.Button();
            this.btnProfPrev = new System.Windows.Forms.Button();
            this.btnProfNext = new System.Windows.Forms.Button();
            this.btnProfLast = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtProfNome
            // 
            this.txtProfNome.Location = new System.Drawing.Point(71, 35);
            this.txtProfNome.Name = "txtProfNome";
            this.txtProfNome.Size = new System.Drawing.Size(220, 20);
            this.txtProfNome.TabIndex = 3;
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(0, 19);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbInativo.TabIndex = 4;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            this.rdbInativo.CheckedChanged += new System.EventHandler(this.rdbInativo_CheckedChanged);
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(72, 19);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAtivo.TabIndex = 5;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // rdbRecusado
            // 
            this.rdbRecusado.AutoSize = true;
            this.rdbRecusado.Location = new System.Drawing.Point(138, 19);
            this.rdbRecusado.Name = "rdbRecusado";
            this.rdbRecusado.Size = new System.Drawing.Size(74, 17);
            this.rdbRecusado.TabIndex = 6;
            this.rdbRecusado.TabStop = true;
            this.rdbRecusado.Text = "Recusado";
            this.rdbRecusado.UseVisualStyleBackColor = true;
            this.rdbRecusado.CheckedChanged += new System.EventHandler(this.rdbRecusado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAtivo);
            this.groupBox1.Controls.Add(this.rdbInativo);
            this.groupBox1.Controls.Add(this.rdbRecusado);
            this.groupBox1.Location = new System.Drawing.Point(62, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 43);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // btnProfFirst
            // 
            this.btnProfFirst.Location = new System.Drawing.Point(15, 110);
            this.btnProfFirst.Name = "btnProfFirst";
            this.btnProfFirst.Size = new System.Drawing.Size(75, 23);
            this.btnProfFirst.TabIndex = 11;
            this.btnProfFirst.Text = "|<";
            this.btnProfFirst.UseVisualStyleBackColor = true;
            this.btnProfFirst.Click += new System.EventHandler(this.btnProfFirst_Click);
            // 
            // btnProfPrev
            // 
            this.btnProfPrev.Location = new System.Drawing.Point(97, 110);
            this.btnProfPrev.Name = "btnProfPrev";
            this.btnProfPrev.Size = new System.Drawing.Size(75, 23);
            this.btnProfPrev.TabIndex = 12;
            this.btnProfPrev.Text = "<";
            this.btnProfPrev.UseVisualStyleBackColor = true;
            this.btnProfPrev.Click += new System.EventHandler(this.btnProfPrev_Click);
            // 
            // btnProfNext
            // 
            this.btnProfNext.Location = new System.Drawing.Point(179, 110);
            this.btnProfNext.Name = "btnProfNext";
            this.btnProfNext.Size = new System.Drawing.Size(75, 23);
            this.btnProfNext.TabIndex = 13;
            this.btnProfNext.Text = ">";
            this.btnProfNext.UseVisualStyleBackColor = true;
            this.btnProfNext.Click += new System.EventHandler(this.btnProfNext_Click);
            // 
            // btnProfLast
            // 
            this.btnProfLast.Location = new System.Drawing.Point(261, 110);
            this.btnProfLast.Name = "btnProfLast";
            this.btnProfLast.Size = new System.Drawing.Size(75, 23);
            this.btnProfLast.TabIndex = 14;
            this.btnProfLast.Text = ">|";
            this.btnProfLast.UseVisualStyleBackColor = true;
            this.btnProfLast.Click += new System.EventHandler(this.btnProfLast_Click);
            // 
            // frmAtivacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 240);
            this.Controls.Add(this.btnProfLast);
            this.Controls.Add(this.btnProfNext);
            this.Controls.Add(this.btnProfPrev);
            this.Controls.Add(this.btnProfFirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtProfNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAtivacoes";
            this.Text = "Ativacoes";
            this.Load += new System.EventHandler(this.frmAtivacoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfNome;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbRecusado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProfFirst;
        private System.Windows.Forms.Button btnProfPrev;
        private System.Windows.Forms.Button btnProfNext;
        private System.Windows.Forms.Button btnProfLast;
    }
}
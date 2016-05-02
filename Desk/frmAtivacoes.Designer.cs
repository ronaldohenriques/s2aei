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
            this.rdbProfInativo = new System.Windows.Forms.RadioButton();
            this.rdbProfAtivo = new System.Windows.Forms.RadioButton();
            this.rdbProfRecusado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProfFirst = new System.Windows.Forms.Button();
            this.btnProfPrev = new System.Windows.Forms.Button();
            this.btnProfNext = new System.Windows.Forms.Button();
            this.btnProfLast = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAvalNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAvalRecusado = new System.Windows.Forms.RadioButton();
            this.rdbAvalAtivo = new System.Windows.Forms.RadioButton();
            this.rdbAvalInativo = new System.Windows.Forms.RadioButton();
            this.btnAvalFirst = new System.Windows.Forms.Button();
            this.btnAvalPrev = new System.Windows.Forms.Button();
            this.btnAvalNext = new System.Windows.Forms.Button();
            this.btnAvalLast = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // rdbProfInativo
            // 
            this.rdbProfInativo.AutoSize = true;
            this.rdbProfInativo.Location = new System.Drawing.Point(6, 19);
            this.rdbProfInativo.Name = "rdbProfInativo";
            this.rdbProfInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbProfInativo.TabIndex = 4;
            this.rdbProfInativo.TabStop = true;
            this.rdbProfInativo.Text = "Inativo";
            this.rdbProfInativo.UseVisualStyleBackColor = true;
            this.rdbProfInativo.CheckedChanged += new System.EventHandler(this.rdbInativo_CheckedChanged);
            // 
            // rdbProfAtivo
            // 
            this.rdbProfAtivo.AutoSize = true;
            this.rdbProfAtivo.Location = new System.Drawing.Point(83, 19);
            this.rdbProfAtivo.Name = "rdbProfAtivo";
            this.rdbProfAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbProfAtivo.TabIndex = 5;
            this.rdbProfAtivo.TabStop = true;
            this.rdbProfAtivo.Text = "Ativo";
            this.rdbProfAtivo.UseVisualStyleBackColor = true;
            this.rdbProfAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // rdbProfRecusado
            // 
            this.rdbProfRecusado.AutoSize = true;
            this.rdbProfRecusado.Location = new System.Drawing.Point(149, 19);
            this.rdbProfRecusado.Name = "rdbProfRecusado";
            this.rdbProfRecusado.Size = new System.Drawing.Size(74, 17);
            this.rdbProfRecusado.TabIndex = 6;
            this.rdbProfRecusado.TabStop = true;
            this.rdbProfRecusado.Text = "Recusado";
            this.rdbProfRecusado.UseVisualStyleBackColor = true;
            this.rdbProfRecusado.CheckedChanged += new System.EventHandler(this.rdbRecusado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbProfAtivo);
            this.groupBox1.Controls.Add(this.rdbProfInativo);
            this.groupBox1.Controls.Add(this.rdbProfRecusado);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Avaliador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome:";
            // 
            // txtAvalNome
            // 
            this.txtAvalNome.Location = new System.Drawing.Point(71, 197);
            this.txtAvalNome.Name = "txtAvalNome";
            this.txtAvalNome.Size = new System.Drawing.Size(220, 20);
            this.txtAvalNome.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAvalRecusado);
            this.groupBox2.Controls.Add(this.rdbAvalAtivo);
            this.groupBox2.Controls.Add(this.rdbAvalInativo);
            this.groupBox2.Location = new System.Drawing.Point(62, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situação";
            // 
            // rdbAvalRecusado
            // 
            this.rdbAvalRecusado.AutoSize = true;
            this.rdbAvalRecusado.Location = new System.Drawing.Point(139, 20);
            this.rdbAvalRecusado.Name = "rdbAvalRecusado";
            this.rdbAvalRecusado.Size = new System.Drawing.Size(74, 17);
            this.rdbAvalRecusado.TabIndex = 2;
            this.rdbAvalRecusado.TabStop = true;
            this.rdbAvalRecusado.Text = "Recusado";
            this.rdbAvalRecusado.UseVisualStyleBackColor = true;
            this.rdbAvalRecusado.CheckedChanged += new System.EventHandler(this.rdbAvalRecusado_CheckedChanged);
            // 
            // rdbAvalAtivo
            // 
            this.rdbAvalAtivo.AutoSize = true;
            this.rdbAvalAtivo.Location = new System.Drawing.Point(83, 19);
            this.rdbAvalAtivo.Name = "rdbAvalAtivo";
            this.rdbAvalAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAvalAtivo.TabIndex = 1;
            this.rdbAvalAtivo.TabStop = true;
            this.rdbAvalAtivo.Text = "Ativo";
            this.rdbAvalAtivo.UseVisualStyleBackColor = true;
            this.rdbAvalAtivo.CheckedChanged += new System.EventHandler(this.rdbAvalAtivo_CheckedChanged);
            // 
            // rdbAvalInativo
            // 
            this.rdbAvalInativo.AutoSize = true;
            this.rdbAvalInativo.Location = new System.Drawing.Point(9, 19);
            this.rdbAvalInativo.Name = "rdbAvalInativo";
            this.rdbAvalInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbAvalInativo.TabIndex = 0;
            this.rdbAvalInativo.TabStop = true;
            this.rdbAvalInativo.Text = "Inativo";
            this.rdbAvalInativo.UseVisualStyleBackColor = true;
            this.rdbAvalInativo.CheckedChanged += new System.EventHandler(this.rdbAvalInativo_CheckedChanged);
            // 
            // btnAvalFirst
            // 
            this.btnAvalFirst.Location = new System.Drawing.Point(16, 287);
            this.btnAvalFirst.Name = "btnAvalFirst";
            this.btnAvalFirst.Size = new System.Drawing.Size(75, 23);
            this.btnAvalFirst.TabIndex = 19;
            this.btnAvalFirst.Text = "|<";
            this.btnAvalFirst.UseVisualStyleBackColor = true;
            this.btnAvalFirst.Click += new System.EventHandler(this.btnAvalFirst_Click);
            // 
            // btnAvalPrev
            // 
            this.btnAvalPrev.Location = new System.Drawing.Point(97, 287);
            this.btnAvalPrev.Name = "btnAvalPrev";
            this.btnAvalPrev.Size = new System.Drawing.Size(75, 23);
            this.btnAvalPrev.TabIndex = 20;
            this.btnAvalPrev.Text = "<";
            this.btnAvalPrev.UseVisualStyleBackColor = true;
            this.btnAvalPrev.Click += new System.EventHandler(this.btnAvalPrev_Click);
            // 
            // btnAvalNext
            // 
            this.btnAvalNext.Location = new System.Drawing.Point(179, 287);
            this.btnAvalNext.Name = "btnAvalNext";
            this.btnAvalNext.Size = new System.Drawing.Size(75, 23);
            this.btnAvalNext.TabIndex = 21;
            this.btnAvalNext.Text = ">";
            this.btnAvalNext.UseVisualStyleBackColor = true;
            this.btnAvalNext.Click += new System.EventHandler(this.btnAvalNext_Click);
            // 
            // btnAvalLast
            // 
            this.btnAvalLast.Location = new System.Drawing.Point(261, 286);
            this.btnAvalLast.Name = "btnAvalLast";
            this.btnAvalLast.Size = new System.Drawing.Size(75, 23);
            this.btnAvalLast.TabIndex = 22;
            this.btnAvalLast.Text = ">|";
            this.btnAvalLast.UseVisualStyleBackColor = true;
            this.btnAvalLast.Click += new System.EventHandler(this.btnAvalLast_Click);
            // 
            // frmAtivacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 477);
            this.Controls.Add(this.btnAvalLast);
            this.Controls.Add(this.btnAvalNext);
            this.Controls.Add(this.btnAvalPrev);
            this.Controls.Add(this.btnAvalFirst);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtAvalNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfNome;
        private System.Windows.Forms.RadioButton rdbProfInativo;
        private System.Windows.Forms.RadioButton rdbProfAtivo;
        private System.Windows.Forms.RadioButton rdbProfRecusado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProfFirst;
        private System.Windows.Forms.Button btnProfPrev;
        private System.Windows.Forms.Button btnProfNext;
        private System.Windows.Forms.Button btnProfLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAvalNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAvalRecusado;
        private System.Windows.Forms.RadioButton rdbAvalAtivo;
        private System.Windows.Forms.RadioButton rdbAvalInativo;
        private System.Windows.Forms.Button btnAvalFirst;
        private System.Windows.Forms.Button btnAvalPrev;
        private System.Windows.Forms.Button btnAvalNext;
        private System.Windows.Forms.Button btnAvalLast;
    }
}
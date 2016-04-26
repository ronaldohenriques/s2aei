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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnProfAtivar = new System.Windows.Forms.Button();
            this.btnProfDesat = new System.Windows.Forms.Button();
            this.btnProfRec = new System.Windows.Forms.Button();
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inativo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ativo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(138, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Recusado";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnProfAtivar
            // 
            this.btnProfAtivar.Location = new System.Drawing.Point(297, 9);
            this.btnProfAtivar.Name = "btnProfAtivar";
            this.btnProfAtivar.Size = new System.Drawing.Size(75, 23);
            this.btnProfAtivar.TabIndex = 7;
            this.btnProfAtivar.Text = "Ativar";
            this.btnProfAtivar.UseVisualStyleBackColor = true;
            // 
            // btnProfDesat
            // 
            this.btnProfDesat.Location = new System.Drawing.Point(297, 33);
            this.btnProfDesat.Name = "btnProfDesat";
            this.btnProfDesat.Size = new System.Drawing.Size(75, 23);
            this.btnProfDesat.TabIndex = 8;
            this.btnProfDesat.Text = "Desativar";
            this.btnProfDesat.UseVisualStyleBackColor = true;
            // 
            // btnProfRec
            // 
            this.btnProfRec.Location = new System.Drawing.Point(297, 58);
            this.btnProfRec.Name = "btnProfRec";
            this.btnProfRec.Size = new System.Drawing.Size(75, 23);
            this.btnProfRec.TabIndex = 9;
            this.btnProfRec.Text = "Recusar";
            this.btnProfRec.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
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
            // 
            // btnProfNext
            // 
            this.btnProfNext.Location = new System.Drawing.Point(179, 110);
            this.btnProfNext.Name = "btnProfNext";
            this.btnProfNext.Size = new System.Drawing.Size(75, 23);
            this.btnProfNext.TabIndex = 13;
            this.btnProfNext.Text = ">";
            this.btnProfNext.UseVisualStyleBackColor = true;
            // 
            // btnProfLast
            // 
            this.btnProfLast.Location = new System.Drawing.Point(261, 110);
            this.btnProfLast.Name = "btnProfLast";
            this.btnProfLast.Size = new System.Drawing.Size(75, 23);
            this.btnProfLast.TabIndex = 14;
            this.btnProfLast.Text = ">|";
            this.btnProfLast.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnProfRec);
            this.Controls.Add(this.btnProfDesat);
            this.Controls.Add(this.btnProfAtivar);
            this.Controls.Add(this.txtProfNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAtivacoes";
            this.Text = "Ativacoes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfNome;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnProfAtivar;
        private System.Windows.Forms.Button btnProfDesat;
        private System.Windows.Forms.Button btnProfRec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProfFirst;
        private System.Windows.Forms.Button btnProfPrev;
        private System.Windows.Forms.Button btnProfNext;
        private System.Windows.Forms.Button btnProfLast;
    }
}
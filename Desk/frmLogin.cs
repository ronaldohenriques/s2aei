using Model.PN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblCliqueAqui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCad frm = new frmCad();
            frm.Show();
        }

        private void btnLoginOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtLogin.Text) || string.IsNullOrWhiteSpace(this.txtSenha.Text) || this.cmbLogin.SelectedItem == null)
            {
                MessageBox.Show("Favor informar todos os campos");
            }
            else
            {
                if (cmbLogin.SelectedItem == "Administrador")
                {
                    String strLogin = this.txtLogin.Text;
                    String strSenha = this.txtSenha.Text;
                    if (pnLogin.Valida(strLogin) && pnLogin.Valida(strSenha))
                    {
                        frmAtivacoes frm = new frmAtivacoes();
                        frm.Show();
                    }
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

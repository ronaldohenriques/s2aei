using Model.DAO;
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
    public partial class frmCad : Form
    {
        /*
         0 - Cadastro inativo ou solicitado
        1 - Cadastro ativo ou aceito
        2 - Cadastro recusado ou excluído
         */

        private const int INATIVO = 0;
        private const int ATIVO = 1;
        private const int RECUSADO = 2;

        public frmCad()
        {
            InitializeComponent();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSolicCad_Click(object sender, EventArgs e)
        {
            if (cmbCadastro.SelectedItem.ToString() == "Professor")
            {
                Professor p = new Professor();

                p.nome = this.txtNome.Text;
                p.emailp = this.txtEmail.Text;
                p.disciplinaP = this.txtDiscP.Text;
                p.departamento = this.txtDepto.Text;
                p.senha = this.txtSenha.Text;
                p.situacao = INATIVO;

                if (!pnProfessor.Inserir(p))
                {
                    MessageBox.Show("Erro ao cadastrar professor!");
                }
                this.Close();
            }
        }
    }
}

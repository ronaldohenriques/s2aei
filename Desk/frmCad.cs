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

        private const byte INATIVO = 0;
        private const byte ATIVO = 1;
        private const byte RECUSADO = 2;

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
            if (cmbCadastro.SelectedItem == "Professor")
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

            if (cmbCadastro.SelectedItem == "Avaliador")
            {
                Avaliador a = new Avaliador();

                a.nome = this.txtNome.Text;
                a.emailAval = this.txtEmail.Text;
                a.areaAtuacao = this.txtArea.Text;
                a.formacao = this.txtFormacao.Text;
                a.senha = this.txtSenha.Text;
                a.situacao = INATIVO;

                if (!pnAvaliador.Inserir(a))
                {
                    MessageBox.Show("Erro ao cadastrar avaliador!");
                }
                this.Close();
            }
        }

        private void frmCad_Load(object sender, EventArgs e)
        {
            this.cmbCadastro.SelectedIndex = 0;
        }

        private void cmbCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCadastro.SelectedItem == "Professor")
            {
                this.txtArea.Enabled = false;
                this.txtFormacao.Enabled = false;
                this.txtDiscP.Enabled = true;
                this.txtDepto.Enabled = true;
            }
            if (this.cmbCadastro.SelectedItem == "Avaliador")
            {
                this.txtArea.Enabled = true;
                this.txtFormacao.Enabled = true;
                this.txtDiscP.Enabled = false;
                this.txtDepto.Enabled = false;
            }
        }
    }
}

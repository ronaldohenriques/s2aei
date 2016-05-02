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
    public partial class frmAtivacoes : Form
    {

        private Professor pa = new Professor();
        /*
         0 - Cadastro inativo ou solicitado
        1 - Cadastro ativo ou aceito
        2 - Cadastro recusado ou excluído
         */

        private const byte INATIVO = 0;
        private const byte ATIVO = 1;
        private const byte RECUSADO = 2;


        public frmAtivacoes()
        {
            InitializeComponent();
        }

        private void btnProfFirst_Click(object sender, EventArgs e)
        {
            pa = pnProfessor.Primeiro();
            txtProfNome.Text = pa.nome;
        }

        private void btnProfNext_Click(object sender, EventArgs e)
        {
            pa = pnProfessor.Proximo();
            txtProfNome.Text = pa.nome;
        }

        private void btnProfLast_Click(object sender, EventArgs e)
        {
            pa = pnProfessor.Ultimo();
            txtProfNome.Text = pa.nome;
        }

        private void btnProfPrev_Click(object sender, EventArgs e)
        {
            pa = pnProfessor.Anterior();
            txtProfNome.Text = pa.nome;
        }

        private void frmAtivacoes_Load(object sender, EventArgs e)
        {
            pa = pnProfessor.Ultimo();
            txtProfNome.Text = pa.nome;
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnProfessor.SetSituacao(pa, INATIVO))
            {
                MessageBox.Show("Erro ao mudar situação!");
            }
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnProfessor.SetSituacao(pa, ATIVO))
            {
                MessageBox.Show("Erro ao mudar situação!");
            }
        }

        private void rdbRecusado_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnProfessor.SetSituacao(pa, RECUSADO))
            {
                MessageBox.Show("Erro ao mudar situação!");
            }
        }
    }
}

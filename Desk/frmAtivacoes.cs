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
        private Avaliador av = new Avaliador();

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
            setProfRadio(pa.situacao);
        }

        private void btnProfPrev_Click(object sender, EventArgs e)
        {
            pa = pnProfessor.Anterior();
            txtProfNome.Text = pa.nome;
            setProfRadio(pa.situacao);
        }

        private void btnProfNext_Click(object sender, EventArgs e)
        {
            pa = pnProfessor.Proximo();
            txtProfNome.Text = pa.nome;
            setProfRadio(pa.situacao);
        }

        private void btnProfLast_Click(object sender, EventArgs e)
        {
            pa = pnProfessor.Ultimo();
            txtProfNome.Text = pa.nome;
            setProfRadio(pa.situacao);
        }

        private void btnAvalFirst_Click(object sender, EventArgs e)
        {
            av = pnAvaliador.Primeiro();
            txtAvalNome.Text = av.nome;
            setAvalRadio(av.situacao);
        }

        private void btnAvalPrev_Click(object sender, EventArgs e)
        {
            av = pnAvaliador.Anterior();
            txtAvalNome.Text = av.nome;
            setAvalRadio(av.situacao);
        }

        private void btnAvalNext_Click(object sender, EventArgs e)
        {
            av = pnAvaliador.Proximo();
            txtAvalNome.Text = av.nome;
            setAvalRadio(av.situacao);
        }

        private void btnAvalLast_Click(object sender, EventArgs e)
        {
            av = pnAvaliador.Ultimo();
            txtAvalNome.Text = av.nome;
            setAvalRadio(av.situacao);
        }

        private void rdbAvalInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnAvaliador.SetSituacao(av, INATIVO))
            {
                MessageBox.Show("Erro ao mudar situação do Avaliador!");
            }
        }

        private void rdbAvalAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnAvaliador.SetSituacao(av, ATIVO))
            {
                MessageBox.Show("Erro ao mudar situação do Avaliador!");
            }
        }

        private void rdbAvalRecusado_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnAvaliador.SetSituacao(av, RECUSADO))
            {
                MessageBox.Show("Erro ao mudar situação do Avaliador!");
            }
        }

        private void frmAtivacoes_Load(object sender, EventArgs e)
        {
            pa = pnProfessor.Ultimo();
            txtProfNome.Text = pa.nome;
            setProfRadio(pa.situacao);

            av = pnAvaliador.Ultimo();
            txtAvalNome.Text = av.nome;
            setAvalRadio(av.situacao);
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnProfessor.SetSituacao(pa, INATIVO))
            {
                MessageBox.Show("Erro ao mudar situação do Professor!");
            }
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnProfessor.SetSituacao(pa, ATIVO))
            {
                MessageBox.Show("Erro ao mudar situação do Professor!");
            }
        }

        private void rdbRecusado_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnProfessor.SetSituacao(pa, RECUSADO))
            {
                MessageBox.Show("Erro ao mudar situação do Professor!");
            }
        }

        private void setProfRadio(byte situacao)
        {
            switch (situacao)
            {
                case INATIVO:
                    rdbProfInativo.Checked = true;
                    break;
                case ATIVO:
                    rdbProfAtivo.Checked = true;
                    break;
                case RECUSADO:
                    rdbProfRecusado.Checked = true;
                    break;
                default:
                    MessageBox.Show("Erro ao informar a situção do Professor!");
                    break;
            }
        }

        private void setAvalRadio(byte situacao)
        {
            switch (situacao)
            {
                case INATIVO:
                    rdbAvalInativo.Checked = true;
                    break;
                case ATIVO:
                    rdbAvalAtivo.Checked = true;
                    break;
                case RECUSADO:
                    rdbAvalRecusado.Checked = true;
                    break;
                default:
                    MessageBox.Show("Erro ao informar a situção do Avaliador!");
                    break;
            }
        }




    }
}

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
    }
}

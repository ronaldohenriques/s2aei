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
    public partial class frmLoginProf : Form
    {
        public frmLoginProf()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbllink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProfCad frm = new frmProfCad();
            frm.Show();
        }
    }
}

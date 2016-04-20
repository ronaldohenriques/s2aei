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
    public partial class frmProfLogin : Form
    {
        public frmProfLogin()
        {
            InitializeComponent();
        }

        private void lblCliqueAqui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProfCad frm = new frmProfCad();
            frm.Show();
        }
    }
}

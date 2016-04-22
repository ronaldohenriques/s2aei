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
        public frmCad()
        {
            InitializeComponent();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

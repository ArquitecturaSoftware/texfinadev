using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TX_Sistema
{
    public partial class MDI_Sistema : Form
    {
        public MDI_Sistema()
        {
            InitializeComponent();
        }

        private void permisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermiso frm = new frmPermiso();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

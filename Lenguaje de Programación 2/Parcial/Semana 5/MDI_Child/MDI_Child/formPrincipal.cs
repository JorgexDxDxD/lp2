using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Child
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void gestionarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarVentas frm = new frmGestionarVentas();
            frm.MdiParent = this;
            frm.Visible = true;
            this.panel1.Visible = false;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

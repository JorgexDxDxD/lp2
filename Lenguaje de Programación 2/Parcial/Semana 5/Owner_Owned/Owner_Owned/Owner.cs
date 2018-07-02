using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owner_Owned
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void btnOwned_Click(object sender, EventArgs e)
        {
            Owned frmOwned = new Owned();
            frmOwned.Owner = this;
            frmOwned.Visible = true;
        }
    }
}

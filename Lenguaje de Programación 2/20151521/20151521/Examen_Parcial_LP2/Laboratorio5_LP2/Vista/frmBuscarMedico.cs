using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmBuscarMedico : Form
    {
        private MedicoBL acceso;
        public frmBuscarMedico()
        {
            InitializeComponent();
            acceso = new MedicoBL();
            dgvMedicos.AutoGenerateColumns = false;

            dgvMedicos.DataSource=acceso.listarMedicos();
        }
        private Medico objetoSeleccionado;

        public Medico ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        private void btnSeleccionar_MouseClick(object sender, MouseEventArgs e)
        {
            objetoSeleccionado = (Medico)dgvMedicos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}

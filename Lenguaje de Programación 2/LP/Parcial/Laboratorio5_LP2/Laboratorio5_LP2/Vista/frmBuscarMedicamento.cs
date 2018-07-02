using Laboratorio3_LP2;
using LogicaNegocio;
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
    public partial class frmBuscarMedicamento : Form
    {
        private MedicamentoBL logicaNegocio;
        private Medicamento objSeleccionado;

        public frmBuscarMedicamento()
        {
            InitializeComponent();
            logicaNegocio = new MedicamentoBL();
            dataGridView1.DataSource = logicaNegocio.listarMedicamentos();
        }

        public Medicamento ObjSeleccionado { get => objSeleccionado; set => objSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            objSeleccionado = (Medicamento)dataGridView1.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}

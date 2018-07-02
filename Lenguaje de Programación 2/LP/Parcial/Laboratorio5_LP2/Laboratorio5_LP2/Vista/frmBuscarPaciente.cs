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
    public partial class frmBuscarPaciente : Form
    {
        private PacienteBL logicaNegocio;
        private Paciente objetoSeleccionado;
        public frmBuscarPaciente()
        {
            InitializeComponent();
            logicaNegocio = new PacienteBL();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = logicaNegocio.listarPacientes();
            //dataGridView1.Columns.Add("DNI","DNI");
            //dataGridView1.Columns["DNI"].DataPropertyName = "DNI";
        }

        public Paciente ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            objetoSeleccionado = (Paciente)dataGridView1.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}

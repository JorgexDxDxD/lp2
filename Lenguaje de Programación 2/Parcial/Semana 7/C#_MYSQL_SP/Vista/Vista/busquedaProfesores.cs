using Entidades;
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
    
    public partial class busquedaProfesores : Form
    {
        private Profesor profesorSeleccionado;
        private ProfesorBL logicaNegocio;
        public busquedaProfesores()
        {
            InitializeComponent();
            logicaNegocio = new ProfesorBL();
            dgvProfesores.DataSource = 
            logicaNegocio.listarProfesores();
        }

        public Profesor ProfesorSeleccionado { get => profesorSeleccionado; set => profesorSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProfesorSeleccionado = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}

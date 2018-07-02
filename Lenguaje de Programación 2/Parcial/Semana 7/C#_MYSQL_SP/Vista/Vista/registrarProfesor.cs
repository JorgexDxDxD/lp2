using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using LogicaNegocio;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class registrarProfesor : Form
    {
        private ProfesorBL logicaNegocio;
        public registrarProfesor()
        {
            InitializeComponent();
            logicaNegocio = new ProfesorBL();
            estadosComponentes(1);
        }

        private void registrarProfesor_Load(object sender, EventArgs e)
        {

        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Profesor p = new Profesor();
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                txtID.Text = logicaNegocio.registrarProfesor(p).ToString();
                MessageBox.Show("Se ha registrado de forma exitosa", "Éxito", MessageBoxButtons.OK,MessageBoxIcon.Information);
                estadosComponentes(3);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Mensaje de Error");
            }
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            estadosComponentes(2);
        }

        public void estadosComponentes(int valor)
        {
            switch (valor)
            {
                //Inicializa Formulario
                case 1:
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    btnGuardar.Enabled = false;
                    break;
                //Nuevo
                case 2:
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = false;
                    txtNombre.Text = "";
                    txtID.Text = "";
                    txtApellido.Text = "";
                    break;
                //Guardado
                case 3:
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busquedaProfesores bP = new busquedaProfesores();
            if (bP.ShowDialog() == DialogResult.OK)
            {
                txtID.Text = bP.ProfesorSeleccionado.Id.ToString();
                txtApellido.Text = bP.ProfesorSeleccionado.Apellido;
                txtNombre.Text = bP.ProfesorSeleccionado.Nombre;
            }
        }
    }
}

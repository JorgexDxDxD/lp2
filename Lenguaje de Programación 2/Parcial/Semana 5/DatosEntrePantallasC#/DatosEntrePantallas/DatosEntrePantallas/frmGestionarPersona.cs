using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosEntrePantallas
{
    public partial class frmGestionarPersona : Form
    {
        private BindingList<Persona> listaPersonas =
                new BindingList<Persona>();
        private int posicion;
        public frmGestionarPersona()
        {
            InitializeComponent();
            
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            p1.Id = 1;
            p1.Nombre = "Juan Ramirez";
            p1.Edad = 28;
            p2.Id = 2;
            p2.Nombre = "Karla Cordova";
            p2.Edad = 20;
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmListarPersonas frm = new frmListarPersonas(listaPersonas);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtID.Text = frm.PersonaSeleccionada.Id.ToString();
                txtNombre.Text = frm.PersonaSeleccionada.Nombre;
                txtEdad.Text = frm.PersonaSeleccionada.Edad.ToString();
                posicion = frm.Posicion;
                btnModificar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Id = Int32.Parse(txtID.Text);
            p.Nombre = txtNombre.Text;
            p.Edad = Int32.Parse(txtEdad.Text);
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtEdad.Enabled = false;
            listaPersonas[posicion] = p;
            btnGuardar.Enabled = false;
            MessageBox.Show(this, "Se ha modificado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

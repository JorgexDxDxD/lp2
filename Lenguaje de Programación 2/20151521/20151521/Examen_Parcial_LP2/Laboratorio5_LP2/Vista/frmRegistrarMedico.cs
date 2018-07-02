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
    
    public partial class frmRegistrarMedico : Form
    {
        private BindingList<Especialidad> especialidades;
        private BindingList<String> nombresEsp;
        private EspecialidadBL accesoEsp;
        private MedicoBL accesoMed;
        public enum Estado
        {
            Inicial, Nuevo, Deshabilitado
        }
        public frmRegistrarMedico()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
            accesoEsp = new EspecialidadBL();
            accesoMed = new MedicoBL();
            especialidades = accesoEsp.listarEspecialidades();
            nombresEsp = new BindingList<string>();
            foreach (Especialidad esp in especialidades)
            {
                nombresEsp.Add(esp.Nombre);
            }
            cbEspecialidad.DataSource= nombresEsp;
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    txtID.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    rbMasculino.Enabled = false;
                    rbFemenino.Enabled = false;
                    txtEdad.Enabled = false;
                    cboEstadoCivil.Enabled = false;
                    txtSalario.Enabled = false;
                    rbTC.Enabled = false;
                    rbTP.Enabled = false;
                    txtColegiatura.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    limpiarComponentes();
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    txtID.Enabled = false;
                    txtDNI.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    rbMasculino.Enabled = true;
                    rbFemenino.Enabled = true;
                    txtEdad.Enabled = true;
                    cboEstadoCivil.Enabled = true;
                    txtSalario.Enabled = true;
                    rbTC.Enabled = true;
                    rbTP.Enabled = true;
                    txtColegiatura.Enabled = true;
                    cbEspecialidad.Enabled = true;
                    limpiarComponentes();
                    break;
                case Estado.Deshabilitado:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    txtID.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    rbMasculino.Enabled = false;
                    rbFemenino.Enabled = false;
                    txtEdad.Enabled = false;
                    cboEstadoCivil.Enabled = false;
                    txtSalario.Enabled = false;
                    rbTC.Enabled = false;
                    rbTP.Enabled = false;
                    txtColegiatura.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtID.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            txtEdad.Text = "";
            cboEstadoCivil.SelectedIndex = -1;
            txtSalario.Text = "";
            rbTC.Checked = false;
            rbTP.Checked = false;
            txtColegiatura.Text = "";
            cbEspecialidad.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiarComponentes(); estadoComponentes(Estado.Nuevo);
            frmBuscarMedico formBuscarMedico = new frmBuscarMedico();
            if (formBuscarMedico.ShowDialog() == DialogResult.OK)
            {
                Medico m = formBuscarMedico.ObjetoSeleccionado;
                txtID.Text = m.Id.ToString();
                txtDNI.Text = m.DNI;
                txtNombre.Text = m.Nombres;
                txtApellido.Text = m.Apellido_Paterno;
                if (m.Sexo == 'M')
                {
                    rbMasculino.Checked = true;
                    rbFemenino.Checked = false;
                }
                if (m.Sexo == 'F')
                {
                    rbMasculino.Checked = false;
                    rbFemenino.Checked = true;
                }

                txtEdad.Text = m.Edad.ToString();

                if (m.EstadoCivil == EstadoCivil.Soltero)
                {
                   
                }

                cboEstadoCivil.SelectedIndex = -1;
                txtSalario.Text = m.Salario.ToString();
                if (m.Dedicacion == Dedicacion.TC)
                {

                    rbTC.Checked = true;
                    rbTP.Checked = false;
                }
                else
                {

                    rbTC.Checked = false;
                    rbTP.Checked = true;
                }
                txtColegiatura.Text = m.Colegiatura;
                cbEspecialidad.SelectedIndex = -1;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Medico m = new Medico();
            try {
                m.DNI = txtDNI.Text;
                Int32.Parse(m.DNI);
                m.Nombres = txtNombre.Text;
                m.Apellido_Paterno = txtApellido.Text;
                if (rbFemenino.Checked)
                    m.Sexo = 'F';
                else
                    m.Sexo = 'M';
                m.Edad = Int32.Parse(txtEdad.Text);
                string nombre= cboEstadoCivil.SelectedText;
                if (nombre == "Soltero")
                    m.EstadoCivil = EstadoCivil.Soltero;
                else if (nombre == "Casado")
                    m.EstadoCivil = EstadoCivil.Casado;
                else m.EstadoCivil = EstadoCivil.Divorciado;

                if (rbTC.Checked)
                    m.Dedicacion = Dedicacion.TC;
                else m.Dedicacion = Dedicacion.TP;

// Console.WriteLine("hola");
                m.Colegiatura = txtColegiatura.Text;
                Int32.Parse(m.Colegiatura);

                Especialidad esp = new Especialidad();
                esp.Nombre = cbEspecialidad.SelectedText;
                esp.Id_especialidad = cbEspecialidad.SelectedIndex + 1;
                m.Especialidad = esp;
                

                estadoComponentes(Estado.Deshabilitado);
                
            }catch(Exception ){
                MessageBox.Show("Campos ingresados Incorrectamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            try
            {

                accesoMed.registrarMedico(m);
            }
            catch (Exception k){
                System.Console.WriteLine(k.ToString());
                
            }

}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Deshabilitado);
        }
    }
}

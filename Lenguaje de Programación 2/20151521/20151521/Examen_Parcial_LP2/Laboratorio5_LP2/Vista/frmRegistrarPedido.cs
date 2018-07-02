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
    public enum estado
    {
        Inicial, Nuevo, Guardar
    }
    public partial class frmRegistrarPedido : Form
    {
        public frmRegistrarPedido()
        {
            InitializeComponent();
            estadoComponentes(estado.Inicial);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente formBuscarCliente = new frmBuscarPaciente();
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscarMedicamento_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente formBuscarMedicamento = new frmBuscarPaciente();
            if (formBuscarMedicamento.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.Guardar);
            MessageBox.Show("Se ha realizado correctamente el registro","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.Nuevo);
        }

        public void estadoComponentes(estado e)
        {
            switch (e)
            {
                case estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    txtIDPaciente.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombreCompleto.Enabled = false;
                    txtIDMedicamento.Enabled = false;
                    txtNombreMedicamento.Enabled = false;
                    txtPresentacion.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtCostoUnitario.Enabled = false;
                    txtTotal.Enabled = false;
                    dgvMedicamentos.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnBuscarMedicamento.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //btnBuscarPedido.Enabled = true;
                    limpiarCampos();
                    break;
                case estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    txtIDPaciente.Enabled = true;
                    txtDNI.Enabled = true;
                    txtNombreCompleto.Enabled = true;
                    txtIDMedicamento.Enabled = true;
                    txtNombreMedicamento.Enabled = true;
                    txtPresentacion.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtCostoUnitario.Enabled = true;
                    txtTotal.Enabled = true;
                    dgvMedicamentos.Enabled = true;
                    btnBuscarCliente.Enabled = true;
                    btnBuscarMedicamento.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnEliminar.Enabled = true;
                    //btnBuscarPedido.Enabled = false;
                    btnCancelar.Enabled = true;
                    limpiarCampos();
                    break;
                case estado.Guardar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    txtIDPaciente.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombreCompleto.Enabled = false;
                    txtIDMedicamento.Enabled = false;
                    txtNombreMedicamento.Enabled = false;
                    txtPresentacion.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtCostoUnitario.Enabled = false;
                    txtTotal.Enabled = false;
                    dgvMedicamentos.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnBuscarMedicamento.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = false;
                    //btnBuscarPedido.Enabled = true;
                    btnCancelar.Enabled = false;
                    break;
            }
        }

        public void limpiarCampos()
        {
            txtIDPaciente.Text = "";
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtIDMedicamento.Text = "";
            txtNombreMedicamento.Text = "";
            txtPresentacion.Text = "";
            txtCantidad.Text = "";
            txtCostoUnitario.Text = "";
            txtCantidad.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.Inicial);
        }     
    }
}

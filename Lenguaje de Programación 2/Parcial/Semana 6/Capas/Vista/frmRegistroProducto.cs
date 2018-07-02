using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
namespace Vista
{
    public enum estado { Inicial, Nuevo, Buscar, Guardar }
    public partial class frmRegistroProducto : Form
    {
        private Producto producto;
        private MedidaBL logNegMedida;
        private ProductoBL logNegProducto;
        public frmRegistroProducto()
        {
            InitializeComponent();
            estadoBotones(estado.Inicial);
            producto = new Producto();
            logNegMedida = new MedidaBL();
            logNegProducto = new ProductoBL();
            BindingList<Medida> lista = new BindingList<Medida>();
            lista = logNegMedida.devolverLista();
            cboMedida.ValueMember = "Nombre";
            foreach (Medida m in lista)
            {
                cboMedida.Items.Add(m);
            }
            dgvPresentaciones.AutoGenerateColumns = false;
            dgvPresentaciones.DataSource = producto.Presentaciones;
        }

        public void estadoBotones(estado e)
        {
            switch (e)
            {
                case (estado.Inicial):
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cboMedida.Enabled = false;
                    txtStock.Enabled = false;
                    txtPrecio.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = false;
                    dgvPresentaciones.Enabled = false;
                    break;
                case (estado.Nuevo):
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cboMedida.Enabled = true;
                    txtStock.Enabled = true;
                    txtPrecio.Enabled = true;
                    dgvPresentaciones.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    limpiarCampos();
                    break;
                case (estado.Buscar):
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    dgvPresentaciones.Enabled = false;
                    cboMedida.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtStock.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    break;
                case estado.Guardar:
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cboMedida.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtStock.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    dgvPresentaciones.Enabled = false;
                    break;
            }
        }

        public void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            cboMedida.SelectedItem = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboMedida.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una medida", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Presentacion p = new Presentacion
            {
                Medida = (Medida)cboMedida.SelectedItem
            };
            try
            {
                p.Precio = Double.Parse(txtPrecio.Text);
            }
            catch (Exception ex) { MessageBox.Show("Debe ingresar un número como precio", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                p.Stock = Int32.Parse(txtStock.Text);
            }
            catch (Exception ex) { MessageBox.Show("Debe ingresar un número entero", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (p.Precio < 0)
            {
                MessageBox.Show("Está asignando un número negativo a precio", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (p.Stock < 0)
            {
                MessageBox.Show("Está asignando un número negativo a la cantidad de stock", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            producto.Presentaciones.Add(p);
            txtPrecio.Text = "";
            txtStock.Text = "";
            cboMedida.SelectedItem = null;
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado un nombre de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("No ha ingresado una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;

            if(producto.Presentaciones.Count == 0)
            {
                MessageBox.Show("No ha ingresado ninguna presentacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (logNegProducto.registrarProducto(producto))
            {
                MessageBox.Show("Se ha registrado con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                return;
            }
            
            estadoBotones(estado.Guardar);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaProductos frmBusqueda = new frmBusquedaProductos();
            if (frmBusqueda.ShowDialog() == DialogResult.OK)
            {
                producto = frmBusqueda.ProductoSeleccionado;
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                dgvPresentaciones.DataSource = producto.Presentaciones;
                estadoBotones(estado.Buscar);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dgvPresentaciones.CurrentRow.Index;
                txtPrecio.Text = producto.Presentaciones[indice].Precio.ToString();
                txtStock.Text = producto.Presentaciones[indice].Stock.ToString();
                cboMedida.SelectedItem = producto.Presentaciones[indice].Medida;
                producto.Presentaciones.RemoveAt(indice);
                dgvPresentaciones.Refresh();
            }
            catch (Exception ex) { MessageBox.Show("Debe seleccionar una presentacion a modificar","Mensaje de Error",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dgvPresentaciones.CurrentRow.Index;
                producto.Presentaciones.RemoveAt(indice);
            }
            catch (Exception ex)
            { MessageBox.Show("Debe seleccionar una presentacion a Eliminar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estadoBotones(estado.Nuevo);
            producto = new Producto();
            dgvPresentaciones.DataSource = producto.Presentaciones;
        }
    }
}

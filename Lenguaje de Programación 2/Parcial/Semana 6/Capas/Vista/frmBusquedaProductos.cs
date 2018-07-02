using Controlador;
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
    public partial class frmBusquedaProductos : Form
    {
        private Producto productoSeleccionado;
        private ProductoBL logicaNegProducto;

        public frmBusquedaProductos()
        {
            InitializeComponent();
            logicaNegProducto = new ProductoBL();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = logicaNegProducto.listarProductos();
        }

        public Producto ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            
            productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}

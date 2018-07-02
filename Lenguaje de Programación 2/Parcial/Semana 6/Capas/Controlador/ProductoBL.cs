using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    
    public class ProductoBL
    {
        private ProductoDA accesoDatosProducto;
        public ProductoBL()
        {
            accesoDatosProducto = new ProductoDA();
        }

        public bool registrarProducto(Producto p)
        {
            return accesoDatosProducto.registrarProducto(p);
        }

        public BindingList<Producto> listarProductos()
        {
            return accesoDatosProducto.devolverLista();
        }
    }
}

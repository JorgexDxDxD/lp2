using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class Producto
    {
        private string _nombre;
        private string _descripcion;
        private BindingList<Presentacion> presentaciones;

        public Producto()
        {
            presentaciones = new BindingList<Presentacion>();
        }

        public Producto(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            presentaciones = new BindingList<Presentacion>();
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public BindingList<Presentacion> Presentaciones { get => presentaciones; set => presentaciones = value; }
    }
}

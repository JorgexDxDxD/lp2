using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class Presentacion
    {
        private Medida _medida;
        private double _precio;
        private int _stock;

        public Presentacion()
        {
            Medida = new Medida();
        }

        public Presentacion(double precio, int stock)
        {
            _precio = precio;
            _stock = stock;
            _medida = new Medida();
        }

        public Medida Medida { get => _medida; set => _medida = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string DevolverMedida { get => _medida.Nombre; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Detalle_Pedido
    {
        private Medicamento _medicamento;
        private int _cantidad;
        private Double _subtotal;

        public Detalle_Pedido(Medicamento medicamento, int cantidad, double subtotal)
        {
            _medicamento = medicamento;
            _cantidad = cantidad;
            _subtotal = subtotal;
        }

        public Medicamento Medicamento { get => _medicamento; set => _medicamento = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Subtotal { get => _subtotal; set => _subtotal = value; }
    }
}

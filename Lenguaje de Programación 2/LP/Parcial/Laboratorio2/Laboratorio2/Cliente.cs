using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public abstract class Cliente
    {
        private int codigoCliente;
        private string telefono;
        private string correo;
        private string direccion;
        private DateTime fechaDeRegistro;
        private List<Venta> ventas;

        public Cliente() { }
        public Cliente(string telefono, string correo, string direccion)
        {
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
            this.fechaDeRegistro = DateTime.Today;
            ventas = new List<Venta>();
        }

        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaDeRegistro { get => fechaDeRegistro; set => fechaDeRegistro = value; }

        public void registrarVenta(Venta v)
        {

        }
        
    }

}

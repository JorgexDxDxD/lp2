using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Gerente : Usuario ,IConsultable
    {

        public Gerente(string nombre, string apellidoPaterno, string apellidoMaterno, string dni, string username, string password)
            : base(nombre, apellidoPaterno, apellidoMaterno, dni, username, password, 0)
        {
        }

        public void consultarVendedoresSede(string sede)
        {

        }
       
        public void asignarVendedorSede(string dniVend,string sede)
        {

        }
        
        public void moverReasignarCliente(string dniVend, string dniCli)
        {

        }

        public void emitirReporteVendedor(string dniVend)
        {

        }

        public void registrarVendedor(string nombre, string apellidoPaterno, string apellidoMaterno, string dni, string username, string password,
            string sexo, double eficiencia, string seguro, string domicilio, string informacion)
        {
            Vendedor v;
            v = new Vendedor(nombre, apellidoPaterno, apellidoMaterno, dni, username, password,
                sexo, eficiencia, seguro, domicilio, informacion);
        }

        public void eliminarVendedor(string dniVend)
        {

        }
        public void revisarCliente(string dni)
        {

        }

        public string consultarDatos()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class Vendedor : Usuario,IConsultable
    {
        private int meta;
        private string sexo;
        private double eficiencia;
        private List<Cliente> listacli;
        private string informacion;
        private string seguro;
        private string domicilio;
        private List<string> telefonos;
        private int horasMensuales;
        private int horasCumplidasMensuales;
        private List<Venta> ventas;

        public Vendedor(string nombre, string apellidoPaterno, string apellidoMaterno, string dni, string username, string password, 
             string sexo, double eficiencia,string seguro,string domicilio,string informacion) :
            base(nombre, apellidoPaterno, apellidoMaterno, dni, username, password, 1){
            this.sexo = sexo;
            this.eficiencia = eficiencia;
            this.seguro = seguro;
            this.informacion = informacion;
            this.domicilio = domicilio;
        }

        public int Meta { get => meta; set => meta = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Eficiencia { get => eficiencia; set => eficiencia = value; }
        public string Informacion { get => informacion; set => informacion = value; }
        public string Seguro { get => seguro; set => seguro = value; }
        public string Domicilio1 { get => domicilio; set => domicilio = value; }
        public List<string> Telefonos { get => telefonos; set => telefonos = value; }
        public int HorasMensuales { get => horasMensuales; set => horasMensuales = value; }
        public int HorasCumplidasMensuales { get => horasCumplidasMensuales; set => horasCumplidasMensuales = value; }
        internal List<Cliente> Listacli { get => listacli; set => listacli = value; }
        internal List<Venta> Ventas { get => ventas; set => ventas = value; }

        public string consultarDatos()
        {
            throw new NotImplementedException();
        }

        public void registrarCliente()
        {

        }
    }
}

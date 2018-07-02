using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class Empresa : Cliente,IConsultable
    {
        private string ruc;
        private string razon;
        private string representante;

        public Empresa(string ruc, string razon, string representante,string telefono, string correo, string direccion) : base(telefono, correo, direccion)
        {
            this.ruc = ruc;
            this.razon = razon;
            this.representante = representante;
        }

        public string Representante { get => representante; set => representante = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Razon { get => razon; set => razon = value; }

        public string consultarDatos()
        {
            throw new NotImplementedException();
        }
    }
}


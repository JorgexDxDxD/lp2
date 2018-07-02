using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class Persona : Cliente, IConsultable
    {
        private string nombre;
        private string apPat;
        private string apMat;
        private string dni;

        public Persona(string nombre, string apPat,string apMat, string dni, string telefono, string correo, string direccion) : 
            base(telefono, correo, direccion)
        {
            this.nombre = nombre;
            this.apMat = apMat;
            this.apPat = apPat;
            this.dni = dni;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPat { get => apPat; set => apPat = value; }
        public string ApMat { get => apMat; set => apMat = value; }
        public string Dni { get => dni; set => dni = value; }

        public string consultarDatos()
        {
            throw new NotImplementedException();
        }

    }
}

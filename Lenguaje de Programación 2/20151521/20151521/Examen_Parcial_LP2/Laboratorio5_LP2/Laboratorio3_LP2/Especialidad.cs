using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Especialidad
    {
        private int _id_especialidad;
        private string _nombre;

        public Especialidad()
        {

        }

        public Especialidad(int id_especialidad, string nombre)
        {
            _id_especialidad = id_especialidad;
            _nombre = nombre;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Id_especialidad { get => _id_especialidad; set => _id_especialidad = value; }
    }
}

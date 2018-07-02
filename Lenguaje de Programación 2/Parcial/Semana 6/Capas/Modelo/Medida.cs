using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class Medida
    {
        private int _id;
        private string _nombre;

        public Medida()
        {

        }
        public Medida(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}

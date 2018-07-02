using System;
using AccesoDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Entidades;

namespace LogicaNegocio
{
    public class ProfesorBL
    {
        private ProfesorDA accesoDatos;

        public ProfesorBL()
        {
            accesoDatos = new ProfesorDA();
        }

        public BindingList<Profesor> listarProfesores()
        {
            return accesoDatos.listarProfesores();
        }
    }
}

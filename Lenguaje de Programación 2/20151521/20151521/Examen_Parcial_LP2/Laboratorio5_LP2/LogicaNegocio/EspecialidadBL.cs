using Modelo;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LogicaNegocio
{
    public class EspecialidadBL
    {
        private EspecialidadDA acceso;

        public EspecialidadBL()
        {
            acceso = new EspecialidadDA();
        }
        public BindingList <Especialidad> listarEspecialidades()
        {
            return acceso.listarEspecialidades();
        }
    }
}

using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class MedicoBL
    {
        private MedicoDA acceso;
        public MedicoBL() {
            acceso = new MedicoDA();
        }

        public void registrarMedico(Medico m)
        {
            acceso.registrarMedico(m);
        }
        public BindingList<Medico> listarMedicos()
        {
            return acceso.listarMedicos();
        }
        
    }
}

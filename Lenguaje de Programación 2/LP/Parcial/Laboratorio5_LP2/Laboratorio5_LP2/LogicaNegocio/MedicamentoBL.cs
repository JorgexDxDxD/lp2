using AccesoDatos;
using Laboratorio3_LP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class MedicamentoBL
    {
        private MedicamentoDA accesoDatos;
        public MedicamentoBL()
        {
            accesoDatos = new MedicamentoDA();
        }

        public BindingList<Medicamento> listarMedicamentos()
        {
            return accesoDatos.listarMedicamentos();
        }

    }
}

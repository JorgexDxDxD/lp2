using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
namespace Controlador
{

    public class MedidaBL
    {
        private MedidaDA accesoDatos;

        public MedidaBL(){
            accesoDatos = new MedidaDA();
        }

        public BindingList<Medida> devolverLista()
        {
            return accesoDatos.devolverLista();
        }
    }
}

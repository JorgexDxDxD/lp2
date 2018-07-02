using AccesoDatos;
using Laboratorio3_LP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PedidoBL
    {
        private PedidoDA accesoDatosPedido;
        private Detalle_PedidoDA accedoDatosDetPed;

        public PedidoBL()
        {
            accesoDatosPedido = new PedidoDA();
            accedoDatosDetPed = new Detalle_PedidoDA();
        }

        public void registrarPedido(Pedido p)
        {
            p.Id_pedido = accesoDatosPedido.registrarPedido(p);
            foreach(Detalle_Pedido dp in p.Detalles_pedido)
            {
                accedoDatosDetPed.registrarDetPedido(dp,p.Id_pedido);
            }
        }
    }
}

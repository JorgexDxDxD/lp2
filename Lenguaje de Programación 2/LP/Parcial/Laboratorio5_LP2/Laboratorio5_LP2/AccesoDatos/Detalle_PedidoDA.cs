using Laboratorio3_LP2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Detalle_PedidoDA
    {
        public void registrarDetPedido(Detalle_Pedido dp, int id_Pedido)
        {
            string cadena = "server=sql10.freemysqlhosting.net;user=sql10236703;password=uiGmDRbEAP;" +
                "port=3306;database=sql10236703;SslMode=none";
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "REGISTRAR_DETALLE_PEDIDO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_FID_PEDIDO", MySqlDbType.Int32).Value =
                id_Pedido;
            comando.Parameters.Add("_FID_MEDICAMENTO", MySqlDbType.Int32).Value =
                dp.Medicamento.Id_medicamento;
            comando.Parameters.Add("_CANTIDAD", MySqlDbType.Int32).Value =
                dp.Cantidad;
            comando.Parameters.Add("_SUBTOTAL", MySqlDbType.Decimal).Value =
                dp.Subtotal;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

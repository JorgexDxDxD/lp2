using Laboratorio3_LP2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PedidoDA
    {
        public int registrarPedido(Pedido p)
        {
            
            string cadena = "server=sql10.freemysqlhosting.net;user=sql10236703;password=uiGmDRbEAP;" +
                "port=3306;database=sql10236703;SslMode=none"; 
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "REGISTRAR_PEDIDO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_FID_PACIENTE", MySqlDbType.Int32).Value =
                p.Paciente.Id;
            comando.Parameters.Add("_TOTAL", MySqlDbType.Decimal).Value =
                p.Total;
            comando.Parameters.Add("_ID", MySqlDbType.Int32).Direction
                = System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            return Int32.Parse
            (comando.Parameters["_ID"].Value.ToString());
            conexion.Close();
            
        }
    }
}

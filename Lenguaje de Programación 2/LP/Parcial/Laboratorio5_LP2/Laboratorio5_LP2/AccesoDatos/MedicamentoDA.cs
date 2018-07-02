using Laboratorio3_LP2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class MedicamentoDA
    {
        public BindingList<Medicamento> listarMedicamentos()
        {
            BindingList<Medicamento> lista = new BindingList<Medicamento>();
            string cadena = "server=sql10.freemysqlhosting.net;user=sql10236703;password=uiGmDRbEAP;" +
                "port=3306;database=sql10236703;SslMode=none";
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "LISTAR_MEDICAMENTOS";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Medicamento m = new Medicamento();
                m.Id_medicamento = reader.GetInt32("ID_MEDICAMENTO");
                m.Nombre = reader.GetString("NOMBRE");
                m.Presentacion = reader.GetString("PRESENTACION");
                m.Costo_Unidad = reader.GetDouble("COSTO_UNIDAD");
                m.Generico_sn = reader.GetBoolean("GENERICO_SN");
                m.Farmaceutica = reader.GetString("FARMACEUTICA");
                lista.Add(m);
            }
            conexion.Close();
            return lista;
        }
    }
}

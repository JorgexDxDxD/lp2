
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class EspecialidadDA
    {
        public EspecialidadDA()
        {

        }
        public BindingList<Especialidad> listarEspecialidades()
        {
            BindingList<Especialidad> lista = new BindingList<Especialidad>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;user=a20151521;database=a20151521;password=QiDSz7;" +
                "port=3306;SslMode=none";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM a20151521.ESPECIALIDAD";
            comando.Connection = con;
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Especialidad esp = new Especialidad();
                esp.Nombre = reader.GetString("NOMBRE");
                esp.Id_especialidad = reader.GetInt32("ID_ESPECIALIDAD");
                lista.Add(esp);
            }
            con.Close();
            return lista;
        }
    }

}

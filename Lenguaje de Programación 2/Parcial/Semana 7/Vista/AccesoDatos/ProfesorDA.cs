using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProfesorDA
    {
        public BindingList<Profesor> listarProfesores()
        {
            BindingList<Profesor> lista = new BindingList<Profesor>();
            String cadena = "server=127.0.0.1;" +
                "user=root;database=lp2;" +
                "port=3306;password=123456;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM PROFESOR";
            comando.Connection = con;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Profesor p = new Profesor();
                p.Id = reader.GetInt32("ID_PROFESOR");
                p.Nombre = reader.GetString("NOMBRE");
                p.Apellido = reader.GetString("NOMBRE");
                lista.Add(p);
            }
            con.Close();
            return lista;
        }
    }
}

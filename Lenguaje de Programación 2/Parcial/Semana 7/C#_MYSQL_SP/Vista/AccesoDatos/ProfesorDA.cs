using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProfesorDA
    {
        public int registrarProfesor(Profesor p)
        {
            String cadena = "server=127.0.0.1;" +
                "user=root;database=lp2;" +
                "port=3306;password=123456;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_PROFESOR";
            comando.Connection = con;
            comando.Parameters.Add("_nombre",MySqlDbType.VarChar).Value = 
                p.Nombre;
            comando.Parameters.Add("_apellido",MySqlDbType.VarChar).Value =
                p.Apellido;
            comando.Parameters.Add("_id_profesor",MySqlDbType.Int32).Direction 
                = System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            con.Close();
            return 
            Int32.Parse
            (comando.Parameters["_id_profesor"].Value.ToString());
        }

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
                p.Apellido = reader.GetString("APELLIDO");
                lista.Add(p);
            }
            con.Close();
            return lista;
        }
    }
}

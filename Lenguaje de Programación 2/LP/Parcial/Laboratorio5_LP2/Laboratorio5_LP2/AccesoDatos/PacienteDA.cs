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
    public class PacienteDA
    {
        public BindingList<Paciente> listarPacientes()
        {
            BindingList<Paciente> lista = new BindingList<Paciente>();
            string cadena = "server=sql10.freemysqlhosting.net;user=sql10236703;password=uiGmDRbEAP;" +
                "port=3306;database=sql10236703;SslMode=none"; 
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "LISTAR_PACIENTES";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Paciente p = new Paciente();
                p.DNI = reader.GetString("DNI");
                p.Id = reader.GetInt32("ID_PERSONA");
                p.Nombres = reader.GetString("NOMBRES");
                p.Apellido_Paterno = reader.GetString("APELLIDO_PATERNO");
                p.ApellidoMaterno = reader.GetString("APELLIDO_MATERNO");
                lista.Add(p);
            }
            conexion.Close();
            return lista;
        }
    }
}

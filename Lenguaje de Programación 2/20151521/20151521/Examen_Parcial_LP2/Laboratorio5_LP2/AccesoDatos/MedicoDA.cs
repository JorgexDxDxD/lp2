using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class MedicoDA
    {
        public MedicoDA()
        {

        }
        public void registrarMedico(Medico m)
        {
            
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;user=a20151521;database=a20151521;password=QiDSz7;" +
                "port=3306;SslMode=none";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "REGISTRAR_MEDICO";
            comando.Connection = con;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = m.DNI;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = m.Nombres;
            comando.Parameters.Add("_APELLIDO_PATERNO", MySqlDbType.VarChar).Value = m.Apellido_Paterno;
            comando.Parameters.Add("_SEXO", MySqlDbType.VarChar).Value = m.Sexo;
            comando.Parameters.Add("_EDAD", MySqlDbType.Int32).Value = m.Edad;

            char c;
            if (m.EstadoCivil == EstadoCivil.Soltero)
                c = 'S';
            else if (m.EstadoCivil == EstadoCivil.Casado)
                c = 'C';
            else c = 'D';
            comando.Parameters.Add("_ESTADO_CIVIL", MySqlDbType.VarChar).Value = c;
            comando.Parameters.Add("_SALARIO", MySqlDbType.Decimal).Value = m.Salario;
            comando.Parameters.Add("_DEDICACION", MySqlDbType.VarChar).Value = m.Dedicacion.ToString();
            comando.Parameters.Add("_COLEGIATURA", MySqlDbType.VarChar).Value = m.Colegiatura;
            comando.Parameters.Add("_ID_ESPECIALIDAD", MySqlDbType.Int32).Value = m.Especialidad.Id_especialidad;

            comando.ExecuteNonQuery();
            MessageBox.Show("inserción correcta");
            con.Close();
        }

        public BindingList<Medico> listarMedicos()
        {
            BindingList<Medico> lista = new BindingList<Medico>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;user=a20151521;database=a20151521;password=QiDSz7;" +
                "port=3306;SslMode=none";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_MEDICOS";
            comando.Connection = con;
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Medico p = new Medico();
                p.Nombres = reader.GetString("NOMBRES");
                System.Console.WriteLine(p.Nombres);
                p.Id= reader.GetInt32("ID_PERSONA");
                p.Sexo = reader.GetChar("SEXO");
                p.DNI = reader.GetString("DNI");
                p.Edad = reader.GetInt32("EDAD");
                p.Colegiatura = reader.GetString("COLEGIATURA");
                p.Salario = reader.GetDouble("SALARIO");
                p.Apellido_Paterno = reader.GetString("APELLIDO_PATERNO");
                p.NombreCompleto = p.Nombres +" "+ p.Apellido_Paterno;
                p.NombreEspecialidad = reader.GetString("NOMBRE");
                lista.Add(p);
            }
            con.Close();
            return lista;
        }
    }

}

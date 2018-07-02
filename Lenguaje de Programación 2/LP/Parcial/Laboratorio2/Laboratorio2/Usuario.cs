using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio2
{
    public abstract class Usuario
    {
        private int codigoUsuario;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string nombre;
        private string correo;
        private string dni;
        private DateTime  fechaDeRegistro;
        private bool activo;

        private string username;    
        private string password;
        private int prioridad; // 1 para vendedor y 0 para gerente

        public Usuario(string nombre, string apellidoPaterno,string apellidoMaterno, string dni, string username,string password,int prioridad)
        {
            this.nombre = nombre;
            this.fechaDeRegistro = DateTime.Today;
            this.apellidoPaterno = apellidoPaterno ;
            this.apellidoMaterno = apellidoMaterno;
            this.dni = dni;
            this.username = username;
            this.password = password;
            this.prioridad = prioridad;
            this.activo = true;
            
        }
    
        public string Dni { get => dni; set => dni = value; }
        public int CodigoUsuario { get => codigoUsuario; set => codigoUsuario = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
    }

}

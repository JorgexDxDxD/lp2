using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace AccesoDatos
{
    public class MedidaDA
    {
        private string ruta = "medidas.txt";

        public BindingList<Medida> devolverLista()
        {
            BindingList<Medida> lista = new BindingList<Medida>();
            FileStream fs = new FileStream(ruta,FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (true)
            {
                string linea = sr.ReadLine();
                if (linea == null) { break; }
                Medida m = new Medida(Int32.Parse(linea), sr.ReadLine());
                lista.Add(m);
            }
            sr.Close();
            fs.Close();
            return lista;
        }
    }
}

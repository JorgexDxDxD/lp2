using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace AccesoDatos
{
    public class ProductoDA
    {
        private string ruta = "productos.dat";
        public bool registrarProducto(Producto p)
        {
            FileStream fs = new FileStream(ruta, FileMode.Append,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(fs, p);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

            
        }

        public BindingList<Producto> devolverLista()
        {
            BindingList<Producto> lista = new BindingList<Producto>();
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            while (true)
            {
                try
                {
                    Producto p = (Producto)bf.Deserialize(fs);
                    lista.Add(p);
                }
                catch (Exception e) { fs.Close(); break; }
            }
            return lista;
            
        }
    }
}

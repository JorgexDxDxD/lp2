using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploClase060418
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
            BindingList<Empleado> listaEmpleados = new BindingList<Empleado>();

            FileStream archivo = 
            new FileStream("./empleados.txt",FileMode.Open, FileAccess.Read);

            StreamReader lector = new StreamReader(archivo);
            while (true)
            {
                System.String linea = lector.ReadLine();
                if (linea == null) break ;
                Empleado e = new Empleado();
                e.Id = Int32.Parse(linea);
                e.Nombre = lector.ReadLine();
                e.Edad = Int32.Parse(lector.ReadLine());
                listaEmpleados.Add(e);
            }

            lector.Close();
            archivo.Close();

            dgvEmpleados.DataSource = listaEmpleados;


        }


    }
}

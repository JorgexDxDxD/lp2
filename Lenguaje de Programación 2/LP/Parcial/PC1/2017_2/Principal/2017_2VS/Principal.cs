using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2VS
{
    class Principal
    {
        static void Main(string[] args)
        {
            TTarjeta e = TTarjeta.VISA;
            Sede sed = new Sede(1,"SEDE SAN MIGUEL","SAN MIGUEL", "UNIVERSITARIA");
            Natural cli = new Natural(12, 71324949, "Jorge", "Alfaro", "Ramos");
            Tarjeta t = new Tarjeta(92501240, 2242, e);
            Ahorros c = new Ahorros(242444,0.52,5123);

            //asignaciones
            c.asignarCliente(cli);
            c.asignarTarjeta(t);
            sed.anadirCuenta(c);

            sed.mostrarClientes();

            System.Console.WriteLine("se ejecutó");
            System.Console.ReadLine();
        }
    }
}

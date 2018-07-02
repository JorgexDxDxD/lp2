using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsProd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Recurso r = new Recurso();
            Productor p = new Productor(r);
            Consumidor c = new Consumidor(r);
            Thread p1 = new Thread(p.producir);
            p1.Name = "Productor 1";
            Thread p2 = new Thread(p.producir);
            p2.Name = "Productor 2";
            Thread p3 = new Thread(p.producir);
            p3.Name = "Productor 3";
            Thread c1 = new Thread(c.consumir);
            c1.Name = "Consumidor 1";
            Thread c2 = new Thread(c.consumir);
            c2.Name = "Consumidor 2";
            Thread c3 = new Thread(c.consumir);
            c3.Name = "Consumidor 2";
            c1.Start();
            c2.Start();
            c3.Start();
            p1.Start();
            p2.Start();
            p3.Start();
            System.Console.Read();
        }
    }
}

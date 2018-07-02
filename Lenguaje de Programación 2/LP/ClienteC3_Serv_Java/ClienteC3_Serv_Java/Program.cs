using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClienteC3_Serv_Java
{
    class Program
    {
        private static  AddWS.SumarWSSoapClient acceso; 

        static void Main(string[] args)
        {
            acceso = new AddWS.SumarWSSoapClient();
            Program p = new Program();
            Thread t1 = new Thread(p.sumar);
            Thread t2 = new Thread(p.mult);
            System.Console.WriteLine(acceso.multiplicar(5, 1));
            t1.Start();
            t2.Start();
            Console.Read();
        }

        public void sumar()
        {
            while (true)
            {
                lock (this) { 
                    int a = 3, b = 4;

                    //Monitor.Wait(this);
                    System.Console.WriteLine(acceso.sumar(a, b));
                    //Monitor.PulseAll(this);
                    //Thread.Sleep(1000);
                }
            }
        }
        public void mult()
        {
            while (true)
            {
                lock(this)
                {
                    int a = 3, b = 4;
                    System.Console.WriteLine(acceso.multiplicar(a, b));
                    //Monitor.PulseAll(this);
                    //Monitor.Wait(this);
                    //Thread.Sleep(1000);
                }
            }
        }
    }
}

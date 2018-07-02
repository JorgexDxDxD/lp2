using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsProd
{
    public class Recurso
    {
        private int cantidad;

        public Recurso()
        {
            System.Console.WriteLine("Se ha creado el recurso");
            this.cantidad = 0;
            System.Console.WriteLine("Cantidad: " + this.cantidad);
        }

        public void producir()
        {
            lock(this){
                while (this.cantidad == 2) Monitor.Wait(this);
                System.Console.WriteLine("Se está produciendo...");
                int temp = this.cantidad;
                temp = temp + 1;
                this.cantidad = temp;
                System.Console.WriteLine("Cantidad: " + this.cantidad);
                Monitor.PulseAll(this);
            }
        }

        public void consumir()
        {
            lock (this)
            {
                while (this.cantidad == 0) Monitor.Wait(this);
                System.Console.WriteLine("Se está consumiendo...");
                int temp = this.cantidad;
                temp = temp - 1;
                this.cantidad = temp;
                System.Console.WriteLine("Cantidad: " + this.cantidad);
                Monitor.PulseAll(this);
            }
        }
    }
}

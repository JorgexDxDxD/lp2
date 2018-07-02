using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsProd
{
    public class Consumidor
    {
        private Recurso r;
        public Consumidor(Recurso r)
        {
            this.r = r;
        }
        public void consumir()
        {
            r.consumir();
        }
    }
}

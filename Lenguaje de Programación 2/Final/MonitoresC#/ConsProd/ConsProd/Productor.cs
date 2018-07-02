using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsProd
{
    public class Productor
    {
        private Recurso r;
        public Productor(Recurso r)
        {
            this.r = r;
        }
        public void producir()
        {
            r.producir();
        }
    }
}

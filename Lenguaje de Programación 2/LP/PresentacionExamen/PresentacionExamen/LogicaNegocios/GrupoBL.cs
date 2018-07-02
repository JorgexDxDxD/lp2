using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class GrupoBL
    {
        private PartidosWS.PartidosWSClient access;

        public GrupoBL()
        {
            access = new PartidosWS.PartidosWSClient();
        }

        public BindingList<PartidosWS.pais> listar_Paises()
        {
            return new BindingList<PartidosWS.pais>(access.listarPaises());
        }
        public BindingList<Grupo> agruparPaises()
        {
            BindingList<PartidosWS.pais> paises = new BindingList<PartidosWS.pais>(access.listarPaises());
            BindingList<Grupo> grupos = new BindingList<Grupo>();
            
            for (char i = 'A'; i <= 'H' ; i++)
            {
                Grupo g = new Grupo();
                g.G = i.ToString();
                grupos.Add(g);
            }

            foreach(PartidosWS.pais p in paises){
                string nombGrupo = p.GRUPO;
                int numGrupo = nombGrupo[0] - 'A';
                grupos[numGrupo].Paises.Add(p);
            }
            return grupos;
        }

    }
}

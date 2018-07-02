using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios.PartidosWS;

namespace LogicaNegocios
{
    public class PartidoBL
    {
        private PartidosWS.PartidosWSClient access;

        public PartidoBL()
        {
            access = new PartidosWS.PartidosWSClient();
        }
        public void asignarPartidos(BindingList<Grupo> grupos )
        {
            BindingList<PartidosWS.partido> partidos = new BindingList<PartidosWS.partido>(access.listarPartidos());
            bool asignado = false;


            foreach (Grupo g in grupos)
            {
                g.Partidos = new BindingList<PartidosWS.partido>();
            }

            foreach (PartidosWS.partido p in partidos)
            {
                foreach(Grupo g in grupos)
                {
                    foreach(PartidosWS.pais pais in g.Paises)
                    {
                        if (pais.ID_PAIS_CLASIFICADO == p.EQUIPO_A || pais.ID_PAIS_CLASIFICADO == p.EQUIPO_B)
                        {
                            g.Partidos.Add(p);
                            asignado = true;
                            break;
                        }
                    }
                    if (asignado)
                    {
                        asignado = false;
                        break;
                    }
                }
            }
            
        }

        public void actualizarPartido(string text1, string text2, PartidosWS.partido p) 
        {
            int score_A = int.Parse(text1);
            int score_B = int.Parse(text2);

            p.GOLES_EQUIPO_A = score_A;
            p.GOLES_EQUIPO_B = score_B;
            p.JUGADO = true;
            access.registrarPartido(p);
        }

        public void eliminar(partido partido)
        {
            access.eliminarPartido(partido);
        }
    }
}

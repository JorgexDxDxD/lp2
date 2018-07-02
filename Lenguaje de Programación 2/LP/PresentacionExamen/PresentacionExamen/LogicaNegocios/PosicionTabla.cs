using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios.PartidosWS;

namespace LogicaNegocios
{
    public class PosicionTabla
    {
        private PartidosWS.pais country;
        private int pos;
        private int pj;
        private int g;
        private int e;
        private int p;
        private int gf;
        private int gc;
        private int dg;
        private int ptos;
        private String nombre;

        public pais Country { get => country; set => country = value; }
        public int Pos { get => pos; set => pos = value; }
        public int Pj { get => pj; set => pj = value; }
        public int G { get => g; set => g = value; }
        public int E { get => e; set => e = value; }
        public int P { get => p; set => p = value; }
        public int Gf { get => gf; set => gf = value; }
        public int Gc { get => gc; set => gc = value; }
        public int Dg { get => dg; set => dg = value; }
        public int Ptos { get => ptos; set => ptos = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public PosicionTabla(PartidosWS.pais country,BindingList<partido> partidos)
        {
            Ptos = 0;
            Dg = 0;
            Gc = 0;
            Gf = 0;
            P = 0;
            E = 0;
            G = 0;
            Pj = 0;
            Nombre = country.NOMBRE;
            
            foreach (partido part in partidos)
            {
                if (part.JUGADO)
                {
                    Pj += 1;
                    if (part.EQUIPO_A == country.ID_PAIS_CLASIFICADO)
                    {
                        Gf += part.GOLES_EQUIPO_A;
                        Gc += part.GOLES_EQUIPO_B;
                        Dg += part.GOLES_EQUIPO_A - part.GOLES_EQUIPO_B;
                        if (part.GOLES_EQUIPO_A > part.GOLES_EQUIPO_B)
                        {
                            G += 1;
                            Ptos += 3;                            
                        }
                        else if(part.GOLES_EQUIPO_A == part.GOLES_EQUIPO_B)
                        {
                            E += 1;
                            Ptos += 1;
                        }
                        else
                        {
                            P += 1;
                        }
                    }

                    else if (part.EQUIPO_B == country.ID_PAIS_CLASIFICADO)
                    {
                        Gf += part.GOLES_EQUIPO_B;
                        Gc += part.GOLES_EQUIPO_A;
                        Dg += part.GOLES_EQUIPO_B - part.GOLES_EQUIPO_A;
                        if (part.GOLES_EQUIPO_B > part.GOLES_EQUIPO_A)
                        {
                            G += 1;
                            Ptos += 3;
                        }
                        else if (part.GOLES_EQUIPO_A == part.GOLES_EQUIPO_B)
                        {
                            E += 1;
                            Ptos += 1;
                        }
                        else
                        {
                            P += 1;
                        }

                    }
                }
            }
        }
    }
}

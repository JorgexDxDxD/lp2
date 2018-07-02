using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios.PartidosWS;

namespace LogicaNegocios
{
    public class Grupo
    {
        private BindingList<PartidosWS.pais> paises;
        private BindingList<PartidosWS.partido> partidos;
        private String g;
        private String nombreGrupo;
        
        public Grupo()
        {
            paises = new BindingList<pais>();
            Partidos = new BindingList<partido>();
        }

        public BindingList<pais> Paises { get => paises; set => paises = value; }
        public string G { get => g; set => g = value; }
        public string NombreGrupo { get => "Grupo "+g; set => nombreGrupo = value; }
        public BindingList<partido> Partidos { get => partidos; set => partidos = value; }
    }
}

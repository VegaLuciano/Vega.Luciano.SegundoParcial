using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tabla
    {
        private List<Voley> listaVoley;
        private List<Futbol> listaFutbol;
        private List<Basquet> listaBasquet;

        public Tabla()
        {
            this.listaVoley = new List<Voley>();
            this.listaFutbol = new List<Futbol>();
            this.listaBasquet = new List<Basquet>();
        }

        public List<Voley> ListaVoley { get => listaVoley; set => listaVoley = value; }
        public List<Futbol> ListaFutbol { get => listaFutbol; set => listaFutbol = value; }
        public List<Basquet> ListaBasquet { get => listaBasquet; set => listaBasquet = value; }

        public Tabla(List<Voley> listaVoley, List<Futbol> listaFutbol, List<Basquet> listaBasquet)
        {
            this.listaVoley = listaVoley;
            this.listaFutbol = listaFutbol;
            this.listaBasquet = listaBasquet;
        }



    }
}

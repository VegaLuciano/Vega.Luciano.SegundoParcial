using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa una tabla que contiene listas de equipos y jugadores de diferentes deportes.
    /// </summary>
    public class Tabla
    {
        private List<Voley> listaVoley;
        private List<Futbol> listaFutbol;
        private List<Basquet> listaBasquet;
        private List<Jugador> listaJugadores;

        public Tabla()
        {
            this.listaVoley = new List<Voley>();
            this.listaFutbol = new List<Futbol>();
            this.listaBasquet = new List<Basquet>();
            this.listaJugadores = new List<Jugador>();
        }

        public List<Voley> ListaVoley { get => listaVoley; set => listaVoley = value; }
        public List<Futbol> ListaFutbol { get => listaFutbol; set => listaFutbol = value; }
        public List<Basquet> ListaBasquet { get => listaBasquet; set => listaBasquet = value; }
        public List<Jugador> ListaJugadores { get => listaJugadores; set => listaJugadores = value; }

        public Tabla(List<Voley> listaVoley, List<Futbol> listaFutbol, List<Basquet> listaBasquet, List<Jugador> listaJugadores)
        {
            this.listaVoley = listaVoley;
            this.listaFutbol = listaFutbol;
            this.listaBasquet = listaBasquet;
            this.listaJugadores = listaJugadores;
        }

        /// <summary>
        /// Asigna jugadores a los equipos según su ID de equipo.
        /// </summary>
        public void DesignarJugadores()
        {
            if (!this.listaJugadores.IsNullOrEmpty())
            {
                foreach (Equipo equipo in this.ListaFutbol)
                {
                    foreach (Jugador jugador in this.listaJugadores)
                    {
                        if (equipo.Id == jugador.IdEquipo)
                        {
                            equipo.Jugadores.Add(jugador);
                        }
                    }
                }
                foreach (Equipo equipo in this.ListaBasquet)
                {
                    foreach (Jugador jugador in this.listaJugadores)
                    {
                        if (equipo.Id == jugador.IdEquipo)
                        {
                            equipo.Jugadores.Add(jugador);
                        }
                    }
                }
                foreach (Equipo equipo in this.ListaVoley)
                {
                    foreach (Jugador jugador in this.listaJugadores)
                    {
                        if (equipo.Id == jugador.IdEquipo)
                        {
                            equipo.Jugadores.Add(jugador);
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Futbol : Equipo, IEquipoConFormacion
    {
        private string colorCamisetaLocal;
        private string colorCamisetaVisitante;

        public Futbol() : base()
        {
            this.deporte = EDeporte.Futbol;
        }

        public Futbol(string nombre, int cantTitulares, EDivisiones division, string entrenador) : base(nombre, cantTitulares, division)
        {
            this.deporte = EDeporte.Futbol;
            this.entrenador = entrenador;
        }

        public Futbol(string nombre, int cantTitulares, EDivisiones division, string entrenador, string camisetaLocal, string camisteVisitante) : this(nombre, cantTitulares, division, entrenador)
        {
            this.colorCamisetaLocal = camisetaLocal;
            this.colorCamisetaVisitante = camisteVisitante;
        }
        public Futbol(string nombre, int cantTitulares, EDivisiones division, string entrenador, string camisetaLocal, string camisteVisitante, EDeporte deporte, int cantSuplentes) : this(nombre, cantTitulares, division, entrenador, camisetaLocal, camisteVisitante)
        {
            this.deporte = deporte;
            this.cantSuplentes = cantSuplentes;
        }

        public override List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string ColorCamiseteLocal { get => colorCamisetaLocal; set => colorCamisetaLocal = value; }
        public string ColorCamisetaVisitante { get => colorCamisetaVisitante; set => colorCamisetaVisitante = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Color Local {this.colorCamisetaLocal}");
            sb.AppendLine($"Color Visitante {this.colorCamisetaVisitante}");
            return sb.ToString();
        }

        public static List<Futbol> OrdenarPorNombre(List<Futbol> lista, bool ascendente)
        {
            if (ascendente)
            {
                return lista.OrderBy(equipo => equipo.Nombre).ToList();
            }
            else
            {
                return lista.OrderByDescending(equipo => equipo.Nombre).ToList();
            }

        }
        public void DeterminarPosiciones()
        {
            int defensaCount = 0;
            int delanteroCount = 0;
            int MediocampistaCount = 0;
            int ArqueroCount = 0;

            foreach (Jugador jugador in this.jugadores)
            {
                if (jugador.EsTitular)
                {
                    if (defensaCount < 3)
                    {
                        jugador.Posicion = "defensa";
                        defensaCount++;
                    }
                    else if (delanteroCount < 3)
                    {
                        jugador.Posicion = "delantero";
                        delanteroCount++;
                    }
                    else if (MediocampistaCount < 3)
                    {
                        jugador.Posicion = "Mediocampista";
                        MediocampistaCount++;
                    }
                    else if (ArqueroCount < 1)
                    {
                        jugador.Posicion = "Arquero";
                        ArqueroCount++;
                    }
                    else
                    {
                        jugador.Posicion = "No tiene";
                    }
                }
            }
        }
        public override string PresentarFormacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Titulares:");
            foreach (Jugador jugador in this.Jugadores)
            {
                Jugador capitan = new Jugador();
                if (jugador == this.jugadores[0])
                {
                    capitan = jugador;
                    sb.AppendLine($"{jugador.Nombre} - Capitan");
                }
                if (jugador.EsTitular == true && jugador !=  capitan)
                {
                    sb.AppendLine(jugador.Nombre);
                }
            }
            sb.AppendLine("Suplentes:");
            foreach (Jugador jugador in this.Jugadores)
            {
                if (jugador.EsTitular == false)
                {
                    sb.AppendLine(jugador.Nombre);
                }
            }

            return sb.ToString();
        }
    }
}

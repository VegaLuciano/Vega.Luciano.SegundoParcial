using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Voley : Equipo, IEquipoConFormacion
    {
        private ECancha cancha;
        private string? sedeDelEquipo;

        public Voley() : base()
        {
            this.deporte = EDeporte.Voley;
        }

        public Voley(string nombre, int cantTitulares, EDivisiones division, string entrenador) : base(nombre, cantTitulares, division)
        {
            this.deporte = EDeporte.Voley;
            this.entrenador = entrenador;
        }

        public Voley(string nombre, int cantTitulares, EDivisiones division, string entrenador, ECancha cancha, string sedeDelEquipo) : this(nombre, cantTitulares, division, entrenador)
        {
            this.cancha = cancha;
            this.sedeDelEquipo = sedeDelEquipo;
        }
        public Voley(string nombre, int cantTitulares, EDivisiones division, string entrenador, ECancha cancha, string sedeDelEquipo, EDeporte deporte, int cantSuplentes) : this(nombre, cantTitulares, division, entrenador, cancha, sedeDelEquipo)
        {
            this.deporte = deporte;
            this.cantSuplentes = cantSuplentes;
        }

        public override List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public ECancha Cancha { get => cancha; set => cancha = value; }
        public string? SedeDelEquipo { get => sedeDelEquipo; set => sedeDelEquipo = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Cancha {this.cancha.ToString()}");
            sb.AppendLine($"Sede {this.sedeDelEquipo}");
            return sb.ToString();
        }

        public static List<Voley> OrdenarPorNombre(List<Voley> lista, bool ascendente)
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
            int puntaCount = 0;
            int liberoCount = 0;
            int armadorCount = 0;
            int zagueroCount = 0;

            foreach (Jugador jugador in this.jugadores)
            {
                if (jugador.EsTitular)
                {
                    if (puntaCount < 2)
                    {
                        jugador.Posicion = "Punta";
                        puntaCount++;
                    }
                    else if (liberoCount < 1)
                    {
                        jugador.Posicion = "Libero";
                        liberoCount++;
                    }
                    else if (armadorCount < 1)
                    {
                        jugador.Posicion = "Armador";
                        armadorCount++;
                    }
                    else if (zagueroCount < 1)
                    {
                        jugador.Posicion = "Zaguero";
                        zagueroCount++;
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
                if (jugador.EsTitular == true && jugador != capitan)
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

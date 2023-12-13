using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Basquet : Equipo, IEquipoConFormacion
    {
        private bool equipoMedico;
        private string? sponsor;

        public Basquet() : base()
        {
            this.deporte = EDeporte.Basquet;
        }

        public Basquet(string nombre, int cantTitulares, EDivisiones division, string entrenador) : base(nombre, cantTitulares, division)
        {
            this.deporte = EDeporte.Basquet;
            this.entrenador = entrenador;
        }

        public Basquet(string nombre, int cantTitulares, EDivisiones division, string entrenador, bool equipoMedico, string sponsor) : this(nombre, cantTitulares, division, entrenador)
        {
            this.equipoMedico = equipoMedico;
            this.sponsor = sponsor;
        }
        public Basquet(string nombre, int cantTitulares, EDivisiones division, string entrenador, bool equipoMedico, string sponsor , EDeporte deporte, int cantSuplentes) : this(nombre, cantTitulares, division, entrenador, equipoMedico, sponsor)
        {
            this.deporte = deporte;
            this.cantSuplentes = cantSuplentes;
        }

        public override List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public bool EquipoMedico { get => equipoMedico; set => equipoMedico = value; }
        public string? Sponsor { get => sponsor; set => sponsor = value; }

        /// <summary>
        /// Convierte la información del equipo de básquetbol a una cadena de texto.
        /// </summary>
        /// <returns>Cadena que representa la información del equipo de básquetbol.</returns>
        public override string ToString()
        {
            string respuesta = "no";
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            if (equipoMedico)
                respuesta = "si";
            sb.AppendLine($"Equipo médico {respuesta}");
            sb.AppendLine($"Sponsor {this.sponsor}");
            return sb.ToString();
        }

        /// <summary>
        /// Ordena la lista de equipos de básquetbol por nombre de forma ascendente o descendente.
        /// </summary>
        /// <param name="lista">Lista de equipos de básquetbol a ordenar.</param>
        /// <param name="ascendente">Indica si la ordenación es ascendente (true) o descendente (false).</param>
        /// <returns>Lista de equipos de básquetbol ordenada por nombre.</returns>
        public static List<Basquet> OrdenarPorNombre(List<Basquet> lista, bool ascendente)
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

        /// <summary>
        /// Determina las posiciones de los jugadores titulares del equipo de básquetbol.
        /// </summary>
        public void DeterminarPosiciones()
        {
            int aleroCount = 0;
            int escoltaCount = 0;
            int pivotCount = 0;
            int alaPivotCout = 0;
            int baseCount = 0;

            foreach (Jugador jugador in this.jugadores)
            {
                if (jugador.EsTitular)
                {
                    if (baseCount < 1)
                    {
                        jugador.Posicion = "Base";
                        baseCount++;
                    }
                    else if (aleroCount < 1)
                    {
                        jugador.Posicion = "Alero";
                        aleroCount++;
                    }
                    else if (escoltaCount < 1)
                    {
                        jugador.Posicion = "Escolta";
                        escoltaCount++;
                    }
                    else if (alaPivotCout < 1)
                    {
                        jugador.Posicion = "Ala-Pivot";
                        alaPivotCout++;
                    }
                    else if (pivotCount < 1)
                    {
                        jugador.Posicion = "Pivot";
                        pivotCount++;
                    }
                    else
                    {
                        jugador.Posicion = "No tiene";
                    }
                }
            }
        }

        /// <summary>
        /// Presenta la formación del equipo de básquetbol, mostrando titulares y suplentes.
        /// </summary>
        /// <returns>Cadena que representa la formación del equipo.</returns>
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

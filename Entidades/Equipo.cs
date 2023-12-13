using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Entidades
{
    public abstract class Equipo 
    {
        protected static int contadorId;
        protected int id;
        protected string nombre;
        protected EDeporte deporte;
        protected int cantTitulares;
        protected int cantSuplentes;
        protected EDivisiones division;
        protected string entrenador;
        protected List<Jugador> jugadores;
  

        static Equipo()
        {
            contadorId = 0;
        }

        public Equipo()
        {
            this.Id = contadorId;
            this.deporte = new EDeporte();
            this.nombre = "Vacio";
            this.division = new EDivisiones();
            this.entrenador = "Vacio";
            this.jugadores = new List<Jugador>();
            contadorId++;
        }

        public Equipo( string nombre, int cantTitulares) :  this()
        {
            this.nombre = nombre;
            this.cantTitulares = cantTitulares;             
        }

        public Equipo( string nombre, int cantTitulares, EDivisiones division) : this(nombre, cantTitulares)
        {
            this.division = division;
        }

        public Equipo( string nombre,  int cantTitulares, EDivisiones division, EDeporte deporte, string entrenador, int cantSuplentes) : this( nombre, cantTitulares, division)
        {
            this.entrenador = entrenador;
            this.deporte = deporte;
            this.cantSuplentes = cantSuplentes;
        }
        public Equipo(int id, string nombre, int cantTitulares, EDivisiones division, EDeporte deporte, string entrenador, int cantSuplentes) : this(nombre, cantTitulares, division)
        {
            this.id = id;
        }

        /// <summary>
        /// Propiedad abstracta que obtiene o establece la lista de jugadores del equipo.
        /// </summary>
        public abstract List<Jugador> Jugadores { get; set;}
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EDeporte Deporte
        {
            get { return deporte; }
            set
            {
                if (Enum.TryParse(value.ToString(), out EDeporte resultado))
                {
                    deporte = resultado;
                }
                else
                {
                    // Puedes manejar la situación de alguna manera, como lanzar una excepción.
                    throw new ArgumentException("Valor no válido para la propiedad Deporte");
                }
            }
        }
        public int CantTitulares { get => cantTitulares; set => cantTitulares = value; }
        public int CantSuplentes { get => cantSuplentes; set => cantSuplentes = value; }
        public EDivisiones Division
        {
            get { return division; }
            set
            {
                if (Enum.TryParse(value.ToString(), out EDivisiones resultado))
                {
                    division = resultado;
                }
                else
                {
                    // Puedes manejar la situación de alguna manera, como lanzar una excepción.
                    throw new ArgumentException("Valor no válido para la propiedad Deporte");
                }
            }
        }
        public string Entrenador { get => entrenador; set => entrenador = value; }

        /// <summary>
        /// Método abstracto que presenta la formación del equipo.
        /// </summary>
        public abstract string PresentarFormacion();

        /// <summary>
        /// Método que establece el ID del equipo para los jugadores y los asigna como titulares.
        /// </summary>
        /// <returns>True si la operación fue exitosa, false en caso contrario.</returns>
        public bool SetearIdEquipoJugadores()
        {
            bool retorno = true;
            int idEquipo = this.id;

            if (!this.Jugadores.IsNullOrEmpty())
            {
                foreach (Jugador jugador in this.Jugadores)
                {
                    if (jugador.Nombre != "Nadie")
                    {
                        jugador.IdEquipo = idEquipo;
                    }
                    else
                    {
                        retorno = false; 
                        break;
                    }
                }
            }
            else
            {
                retorno = false; 
            }

            return retorno;
        }

        

        protected virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id:{this.id}");
            sb.AppendLine($"Nombre: {this.nombre} ");
            sb.AppendLine($"Deporte: {this.deporte.ToString()}");
            sb.AppendLine($"Entrenador: {this.entrenador}");
            sb.AppendLine($"Division: {this.division.ToString()}");
            sb.AppendLine($"Jugadores: {this.jugadores.Count}");
            sb.AppendLine($"Suplentes: {this.cantSuplentes}");
            sb.AppendLine($"Titulares: {this.cantTitulares}");
            return sb.ToString();
        }

        /// <summary>
        /// Método estático que elige aleatoriamente a los titulares del equipo.
        /// </summary>
        /// <param name="lista">Lista de jugadores.</param>
        /// <param name="cantidadTitulares">Cantidad de titulares a elegir.</param>
        public static void ElegirTitulares(List<Jugador> lista, int cantidadTitulares)
        {
            Random random = new Random();
            if (lista != null)
            {
                List<int> indicesACambiar = Enumerable.Range(0, lista.Count).ToList();
                indicesACambiar = indicesACambiar.OrderBy(x => random.Next()).Take(cantidadTitulares).ToList();

                // Cambiar los elementos correspondientes a true
                foreach (int indice in indicesACambiar)
                {
                    lista[indice].EsTitular = true;
                }
            }

        }
        /// <summary>
        /// Método estático que cuenta la cantidad de titulares en la lista de jugadores.
        /// </summary>
        /// <param name="lista">Lista de jugadores.</param>
        /// <returns>Cantidad de titulares.</returns>
        public static int ContarTitulares(List<Jugador> lista)
        {
            int contador = 0;

            foreach (Jugador item in lista)
            {
                if (item.EsTitular == true)
                {
                    contador++;
                }
            }

            return contador;
        }
        /// <summary>
        /// Método que retorna una representación en cadena del objeto.
        /// </summary>
        /// <returns>Cadena que representa al objeto.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Sobrecarga del operador de adición que agrega un jugador al equipo.
        /// </summary>
        /// <param name="equipo">Equipo al que se agrega el jugador.</param>
        /// <param name="jugador">Jugador a agregar.</param>
        /// <returns>Equipo actualizado.</returns>
        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.IndexOf(jugador) == -1)
            {
                equipo.jugadores.Add(jugador);
            }
            else
            {
                equipo.jugadores[equipo.jugadores.IndexOf(jugador)] = jugador;
            }

            return equipo;
        }

        /// <summary>
        /// Sobrecarga del operador de sustracción que elimina un jugador del equipo.
        /// </summary>
        /// <param name="equipo">Equipo del que se elimina el jugador.</param>
        /// <param name="jugador">Jugador a eliminar.</param>
        /// <returns>Equipo actualizado.</returns>
        public static Equipo operator -(Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.IndexOf(jugador) != -1)
            {
                equipo.jugadores.Remove(jugador);
            }

            return equipo;
        }
    }
}
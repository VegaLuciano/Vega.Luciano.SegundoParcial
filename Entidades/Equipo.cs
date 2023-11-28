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
            this.nombre = "None";
            this.division = new EDivisiones();
            this.entrenador = "None";
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

        public abstract string PresentarFormacion();

        protected virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} ");
            sb.AppendLine($"Deporte: {this.deporte}");
            sb.AppendLine($"Entrenador: {this.entrenador}");
            sb.AppendLine($"Division: {this.division.ToString()}");
            sb.AppendLine($"Jugadores: {this.jugadores.Count}");
            sb.AppendLine($"Suplentes: {this.cantSuplentes}");
            sb.AppendLine($"Titulares: {this.cantTitulares}");
            return sb.ToString();
        }

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

        public override string ToString()
        {
            return this.Mostrar();
        }

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
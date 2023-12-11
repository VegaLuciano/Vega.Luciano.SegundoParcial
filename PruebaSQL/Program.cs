
using Entidades;
using System.Drawing;

namespace PruebaSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccesoDatosEquipo accesoDatos = new AccesoDatosEquipo();

            if (accesoDatos.ProbarConneccion())
            {
                Console.WriteLine("Se conectó");
            }
            else
            {
                Console.WriteLine("No se conectó");
            }

            List<Jugador> jugadores = accesoDatos.TraerJugadores();

            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine(jugador.ToString()); 
            }

            Console.ReadKey();
        }
    }
}
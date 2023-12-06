
using Entidades;

namespace PruebaSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccesoDatosJugador accesoDatos = new AccesoDatosJugador();

            if (accesoDatos.ProbarConexion()) 
            {
                Console.WriteLine("Se conectó");
            }
            else
            {
                Console.WriteLine("No se conectó");
            }
            Console.ReadKey();
        }
    }
}
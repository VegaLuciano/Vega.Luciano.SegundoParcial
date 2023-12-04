
using Entidades;

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
            Console.ReadKey();
        }
    }
}
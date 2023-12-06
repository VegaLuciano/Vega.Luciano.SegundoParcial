
using Entidades;
using System.Drawing;

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



            // Crear un objeto Color con el color Rojo
            Color colorRojo = Color.Red;

            // Obtener el nombre del color Rojo
            string nombreColorRojo = colorRojo.Name;

            // Mostrar el resultado
            Console.WriteLine($"Nombre del color Rojo: {nombreColorRojo}");
            Console.ReadKey();
        }
    }
}
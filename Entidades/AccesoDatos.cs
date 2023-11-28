using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoDatosEquipo
    {
        public SqlCommand comando;
        private SqlConnection coneccion;
        private static string connectionString;
        private SqlDataReader lector;
        public List<Futbol> listaFutbol;
        public List<Voley> listaVoley;
        public List<Basquet> listaBasquet;


        static AccesoDatosEquipo() 
        {
            AccesoDatosEquipo.connectionString = Properties.Resources.miConeccion;
        }

        public AccesoDatosEquipo()
        {
            coneccion = new SqlConnection(AccesoDatosEquipo.connectionString);
            this.listaFutbol = new List<Futbol>();
            this.listaBasquet = new List<Basquet>();
            this.listaVoley = new List<Voley>();
            this.ActualizarListas();
        }

        public void ActualizarListas()
        {
            this.listaFutbol = this.TraerEquipo<Futbol>();
            this.listaVoley = this.TraerEquipo<Voley>();
            this.listaBasquet = this.TraerEquipo<Basquet>();
        }
        public bool ProbarConneccion() 
        {
            bool retorno = false;

            try
            {
                this.coneccion.Open();
                retorno = true;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                if (this.coneccion.State == ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }

            return retorno;
        }

        public List<T> TraerEquipo<T>() where T : Equipo, new()
        {
            List<T> lista = new List<T>();

            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text; 

            object tipoDeDato = typeof(T);
            switch (tipoDeDato)
            {
                case Futbol:
                    Futbol futbol = new Futbol();
                    this.comando.CommandText = "SELECT * from Futbol";
                    break;
                case Voley:
                    Voley voley = new Voley();
                    this.comando.CommandText = "SELECT * from Voley";
                    break;
                case Basquet:
                    Basquet basquet = new Basquet();
                    this.comando.CommandText = "SELECT * from Basquet";
                    break;
            }
            try
            { 
                this.comando.Connection = this.coneccion;

                this.coneccion.Open();
               
                this.lector = this.comando.ExecuteReader();

                while (lector.Read()) 
                {
                    T equipo = new T();

                    if (tipoDeDato is Futbol)
                    {
                        this.PrepararComandoEquipo(equipo as Futbol);
                    }
                    else if (tipoDeDato is Voley)
                    {
                        this.PrepararComandoEquipo(equipo as Voley);
                    }
                    else if (tipoDeDato is Basquet)
                    {
                        this.PrepararComandoEquipo(equipo as Basquet);
                    }
                    lista.Add(equipo);
                }

                this.lector.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }

            return lista;
        }

        public void AsignarAtributosLector(Equipo equipo)
        {
            equipo.Id = (int)this.lector["id"];
            equipo.Nombre = (string)this.lector["nombre"];
            string deporteString = (string)this.lector["deporte"];
            equipo.Deporte = ConvertirStringAEnum<EDeporte>(deporteString);
            equipo.CantTitulares = (int)this.lector["cantTitulares"];
            equipo.CantSuplentes = (int)this.lector["cantSuplentes"];
            string divisionString = (string)this.lector["division"];
            equipo.Division = ConvertirStringAEnum<EDivisiones>(divisionString);
            equipo.Entrenador = (string)this.lector["entrenador"];
        }
        public void AsignarAtributosLector(Futbol equipo)
        {
            AsignarAtributosLector(equipo);
            Color colorVisitante = ConvertirStringAColor((string)this.lector["colorCamisetaVisitante"]);
            equipo.ColorCamisetaVisitante = colorVisitante;
            Color colorLocal = ConvertirStringAColor((string)this.lector["colorCamisetLocal"]);
            equipo.ColorCamiseteLocal = colorVisitante;
        }
        public void AsignarAtributosLector(Basquet equipo)
        {
            AsignarAtributosLector(equipo);
            equipo.EquipoMedico = (bool)this.lector["equipoMedico"];
            equipo.Sponsor = (string)this.lector["sponsor"];

        }
        public void AsignarAtributosLector(Voley equipo)
        {
            AsignarAtributosLector(equipo);
            equipo.SedeDelEquipo = (string)this.lector["posicion"];
            string cancha = (string)this.lector["cancha"];
            equipo.Cancha = ConvertirStringAEnum<ECancha>(cancha);
        }
      
        public void PrepararComandoEquipo(Equipo equipo)
        {
            this.comando.Parameters.Clear();
            this.comando.Parameters.AddWithValue("@id", equipo.Id);
            this.comando.Parameters.AddWithValue("@nombre", equipo.Nombre);
            this.comando.Parameters.AddWithValue("@cantTitulares", equipo.CantTitulares);
            this.comando.Parameters.AddWithValue("@cantSuplentes", equipo.CantSuplentes);
            this.comando.Parameters.AddWithValue("@division", equipo.Division);
            this.comando.Parameters.AddWithValue("@entrenador", equipo.Entrenador);
        }

        public void PrepararComandoEquipo(Voley voley)
        {
            if (voley != null)
            {
                PrepararComandoEquipo((Equipo)voley);
                this.comando.Parameters.AddWithValue("@cancha", voley.Cancha);
                this.comando.Parameters.AddWithValue("@sedeDelEquipo", voley.SedeDelEquipo);
            }
        }
        public void PrepararComandoEquipo(Futbol futbol)
        {
            if (futbol != null)
            {
                PrepararComandoEquipo((Equipo)futbol);
                this.comando.Parameters.AddWithValue("@colorCamiseteLocal", futbol.ColorCamiseteLocal);
                this.comando.Parameters.AddWithValue("@colorCamisetaVisitante", futbol.ColorCamisetaVisitante);

            }
        }
        public void PrepararComandoEquipo(Basquet basquet)
        {
            if (basquet != null)
            {
                PrepararComandoEquipo((Equipo)basquet);
                this.comando.Parameters.AddWithValue("@equipoMedico", basquet.EquipoMedico);
                this.comando.Parameters.AddWithValue("@sponsor", basquet.Sponsor);
            }
        }
        public bool EliminarEquipo(Equipo equipo)
        {
            bool retorno = false;

            try
            {
                this.coneccion.Open();
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.Connection = this.coneccion;

                this.comando.Parameters.Clear();
                this.comando.Parameters.AddWithValue("@id", equipo.Id);

                if (equipo is Voley)
                {
                    this.comando.CommandText = "DELETE FROM Voley WHERE id = @id";

                }
                else if (equipo is Futbol)
                {
                    this.comando.CommandText = "DELETE FROM Futbol WHERE id = @id";
                }
                else if (equipo is Basquet)
                {
                    this.comando.CommandText = "DELETE FROM Basquet WHERE id = @id";
                }
                else
                {
                    // Tipo de dato no válido
                }

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    this.ActualizarListas();
                    retorno = true;
                }
                else if (filasAfectadas == 0)
                {
                    // No se encontró ninguna fila para eliminar
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones si es necesario
            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }

            return retorno;
        }
        private TEnum ConvertirStringAEnum<TEnum>(string valorDesdeBD) where TEnum : struct
        {
            if (Enum.TryParse(valorDesdeBD, true, out TEnum resultado))
            {
                return resultado;
            }
            else
            {
                // Manejar la situación si la conversión no tiene éxito
                throw new ArgumentException($"Valor no válido para el enumerado {typeof(TEnum).Name}");
            }
        }
        private System.Drawing.Color ConvertirStringAColor(string valorDesdeBD)
        {
            if (System.Drawing.Color.FromName(valorDesdeBD).IsKnownColor)
            {
                return System.Drawing.Color.FromName(valorDesdeBD);
            }
            else
            {
                // Manejar la situación si la conversión no tiene éxito
                throw new ArgumentException($"Valor no válido para el tipo Color");
            }
        }
         public bool AgregarEquipo(Equipo equipo)
        {
            bool retorno = false;
            try
            {
                this.coneccion.Open();

                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                if (equipo is Futbol)
                {
                    this.PrepararComandoEquipo((Futbol)equipo);
                    this.listaFutbol.Add((Futbol)equipo);
                    this.comando.CommandText = "INSERT into Futbol (nombre, cantTitulares, cantSuplentes, division, entrenador, colorCamisetaLocal, colorCamisetaVisitante) " +
                        "VALUES (@nombre, @cantTitulares, @cantSuplentes, @division, @entrenador, @colorCamisetaLocal, @colorCamisetaVisitante)"; ;
                }
                else if (equipo is Voley) 
                {
                    this.PrepararComandoEquipo((Voley)equipo);
                    this.listaVoley.Add((Voley)equipo);
                    this.comando.CommandText = "INSERT into Futbol (nombre, cantTitulares, cantSuplentes, division, entrenador, cancha, sedeDelEquipo) " +
                        "VALUES (@nombre, @cantTitulares, @cantSuplentes, @division, @entrenador, @cancha, @sedeDelEquipo)"; 
                }
                else if (equipo is Basquet)
                {
                    this.PrepararComandoEquipo((Basquet)equipo);
                    this.listaBasquet.Add((Basquet)equipo);
                    this.comando.CommandText = "INSERT into Futbol (nombre, cantTitulares, cantSuplentes, division, entrenador, equipoMedico, sponsor) " +
                         "VALUES (@nombre, @cantTitulares, @cantSuplentes, @division, @entrenador, @equipoMedico, @sponsor)"; 
                }

                this.comando.Connection = this.coneccion;
                
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if(filasAfectadas == 1 ) 
                {
                    //una vez que se realizo la carga de mis datos actualizo par tener en mis listas locales el id
                    this.ActualizarListas();

                    retorno = true;
                }
            }
            catch   ( Exception e )
            {
                // Handle exceptions if needed
            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }
            return retorno;
        }
        public bool ModificarDato(Equipo equipo)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;


                if (equipo is Futbol)
                {
                    this.PrepararComandoEquipo(equipo);
                    this.comando.CommandText = "INSERT into Futbol (nombre, cantTitulares, cantSuplentes, division, entrenador, colorCamisetaLocal, colorCamisetaVisitante) " +
                        "VALUES (@nombre, @cantTitulares, @cantSuplentes, @division, @entrenador, @colorCamisetaLocal, @colorCamisetaVisitante)";
                }
                else if (equipo is Voley)
                {
                    this.PrepararComandoEquipo(equipo);
                    this.comando.CommandText = "UPDATE Voley SET nombre = @nombre, apellido = @apellido, edad = @edad, dni = @dni, aptoMedico = @aptoMedico, federado = @federado, genero = @genero, posicion = @posicion, altura = @altura, partidosJugados = @partidosJugados, categoria = @categoria WHERE id = @id";
                }
                else if (equipo is Basquet)
                {
                    this.PrepararComandoEquipo(equipo);
                    this.comando.CommandText = "INSERT into Basquet (nombre, cantTitulares, cantSuplentes, division, entrenador, equipoMedico, sponsor) " +
                        "VALUES (@nombre, @cantTitulares, @cantSuplentes, @division, @entrenador, @equipoMedico, @sponsor)";
                }

                this.comando.Connection = this.coneccion;
                this.coneccion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    this.ActualizarListas();
                    retorno = true;
                }
                else if (filasAfectadas == 0)
                {

                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if needed
            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }
            return retorno;
        }

    }
}

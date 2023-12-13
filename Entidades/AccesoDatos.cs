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
        public List<Jugador> listaJugadores;

        static AccesoDatosEquipo()
        { 
            AccesoDatosEquipo.connectionString = Properties.Resources.miConeccion;
        }

        public AccesoDatosEquipo()
        {
            this.coneccion = new SqlConnection(AccesoDatosEquipo.connectionString);
            this.listaFutbol = new List<Futbol>();
            this.listaBasquet = new List<Basquet>();
            this.listaVoley = new List<Voley>();
            this.listaJugadores = new List<Jugador>();
            this.ActualizarListas();
        }

        public void ActualizarListaJugadores()
        {
            this.listaJugadores = this.TraerJugadores();
        }

        public void ActualizarListas()
        {
            this.listaFutbol = this.TraerEquipos<Futbol>();
            this.listaVoley = this.TraerEquipos<Voley>();
            this.listaBasquet = this.TraerEquipos<Basquet>();
            this.ActualizarListaJugadores();
        }
        public bool ProbarConneccion()
        {
            bool retorno = false;

            try
            {
                this.coneccion.Open();
                retorno = true;
            }
            catch (Exception ex)
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

        #region asignaciones 
        public void AsignarAtributosLectorBase(Equipo equipo)
        {
            equipo.Id = (int)this.lector.GetInt32(0);
            equipo.Nombre = this.lector["nombre"] != DBNull.Value ? (string)this.lector["nombre"] : null;
            string deporteString = (string)this.lector["deporte"];
            equipo.Deporte = ConvertirStringAEnum<EDeporte>(deporteString);
            equipo.CantTitulares = (int)this.lector["cantTitulares"];
            equipo.CantSuplentes = (int)this.lector["cantSuplentes"];
            string divisionString = (string)this.lector["division"];
            equipo.Division = ConvertirStringAEnum<EDivisiones>(divisionString);
            equipo.Entrenador = this.lector["entrenador"] != DBNull.Value ? (string)this.lector["entrenador"] : null;
        }
        public void AsignarAtributosLectorFutbol(Futbol equipo)
        {
            AsignarAtributosLectorBase(equipo);
            equipo.ColorCamisetaVisitante = (string)this.lector["colorCamisetaVisitante"];
            equipo.ColorCamiseteLocal = (string)this.lector["colorCamisetaLocal"];
        }
        public void AsignarAtributosLectorBasquet(Basquet equipo)
        {
            AsignarAtributosLectorBase(equipo);
            equipo.EquipoMedico = (bool)this.lector["equipoMedico"];
            equipo.Sponsor = (string)this.lector["sponsor"];

        }
        public void AsignarAtributosLectorVoley(Voley equipo)
        {
            AsignarAtributosLectorBase(equipo);
            equipo.SedeDelEquipo = (string)this.lector["sedeDelEquipo"];
            string cancha = (string)this.lector["cancha"];
            equipo.Cancha = ConvertirStringAEnum<ECancha>(cancha);
        }
        public void AsignarAtributosLectorJugador(Jugador jugador)
        {
            jugador.Nombre = (string)this.lector["nombre"];
            jugador.Apellido = (string)this.lector["apellido"];
            jugador.IdEquipo = (int)this.lector["idEquipo"];
            jugador.Genero = ConvertirStringAEnum<EGenero>((string)this.lector["genero"]);
            jugador.Dni = (long)this.lector["dni"];
            jugador.Edad = (int)this.lector["edad"];
            jugador.Division = ConvertirStringAEnum<EDivisiones>((string)this.lector["division"]);
            jugador.Altura = (double)this.lector["altura"];
            jugador.EsTitular = (bool)this.lector["esTitular"];
            jugador.Deporte = ConvertirStringAEnum<EDeporte>((string)this.lector["deporte"]);
        }
 
        public void PrepararComandoEquipoBase(Equipo equipo)
        {
            this.comando.Parameters.Clear();
            this.comando.Parameters.AddWithValue("@id", equipo.Id);
            this.comando.Parameters.AddWithValue("@nombre", equipo.Nombre);
            this.comando.Parameters.AddWithValue("@deporte", equipo.Deporte.ToString()); ;
            this.comando.Parameters.AddWithValue("@cantTitulares", equipo.CantTitulares);
            this.comando.Parameters.AddWithValue("@cantSuplentes", equipo.CantSuplentes);
            this.comando.Parameters.AddWithValue("@division", equipo.Division.ToString()); ;
            this.comando.Parameters.AddWithValue("@entrenador", equipo.Entrenador);
        }
        public void PrepararComandoEquipo(Voley voley)
        {
            if (voley != null)
            {
                PrepararComandoEquipoBase(voley);
                this.comando.Parameters.AddWithValue("@cancha", voley.Cancha.ToString());
                this.comando.Parameters.AddWithValue("@sedeDelEquipo", voley.SedeDelEquipo);
            }
        }
        public void PrepararComandoEquipo(Futbol futbol)
        {
            if (futbol != null)
            {
                PrepararComandoEquipoBase(futbol);
                this.comando.Parameters.AddWithValue("@colorCamisetaLocal", futbol.ColorCamiseteLocal.ToString());
                this.comando.Parameters.AddWithValue("@colorCamisetaVisitante", futbol.ColorCamisetaVisitante.ToString());
            }
        }
        public void PrepararComandoEquipo(Basquet basquet)
        {
            if (basquet != null)
            {
                PrepararComandoEquipoBase(basquet);
                this.comando.Parameters.AddWithValue("@equipoMedico", basquet.EquipoMedico);
                this.comando.Parameters.AddWithValue("@sponsor", basquet.Sponsor);
            }
        }
        public void PrepararComandoJugador(Jugador jugador)
        {
            this.comando.Parameters.Clear();
            this.comando.Parameters.AddWithValue("@nombre", jugador.Nombre);
            this.comando.Parameters.AddWithValue("@apellido", jugador.Apellido);
            this.comando.Parameters.AddWithValue("@idEquipo", jugador.IdEquipo);
            this.comando.Parameters.AddWithValue("@genero", jugador.Genero.ToString());
            this.comando.Parameters.AddWithValue("@dni", jugador.Dni);
            this.comando.Parameters.AddWithValue("@edad", jugador.Edad);
            this.comando.Parameters.AddWithValue("@division", jugador.Division.ToString());
            this.comando.Parameters.AddWithValue("@altura", jugador.Altura);
            this.comando.Parameters.AddWithValue("@esTitular", jugador.EsTitular);
            this.comando.Parameters.AddWithValue("@deporte", jugador.Deporte.ToString());
            this.comando.Parameters.AddWithValue("@posicion", jugador.Posicion);
        }
       
        #endregion 

        #region equipos
        public List<T> TraerEquipos<T>() where T : Equipo, new()
        {
            List<T> lista = new List<T>();

            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;

            string tabla = typeof(T).Name;

            this.comando.CommandText = $"SELECT * FROM {tabla}";

            try
            {
                this.comando.Connection = this.coneccion;

                this.coneccion.Open();

                this.lector = this.comando.ExecuteReader();

                while (lector.Read())
                {
                    T equipo = new T();

                    if (tabla == "Voley")
                    {
                        AsignarAtributosLectorVoley(equipo as Voley);
                    }
                    if (tabla == "Futbol")
                    {
                        AsignarAtributosLectorFutbol(equipo as Futbol);
                    }
                    if (tabla == "Basquet")
                    {
                        AsignarAtributosLectorBasquet(equipo as Basquet);
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
        public int AgregarDato(Equipo equipo)
        {
            int retorno = 0;
            try
            { 
                this.coneccion.Open();

                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                if (equipo is Futbol)
                {
                    this.PrepararComandoEquipo((Futbol)equipo);
                    this.listaFutbol.Add((Futbol)equipo);
                    this.comando.CommandText = "INSERT into Futbol(id, nombre, deporte, cantTitulares, cantSuplentes, division, entrenador, colorCamisetaLocal, colorCamisetaVisitante)" +
                        "VALUES (@id, @nombre, @deporte, @cantTitulares, @cantSuplentes, @division, @entrenador, @colorCamisetaLocal, @colorCamisetaVisitante)"; 
                }
                else if (equipo is Voley)
                {
             
                    this.PrepararComandoEquipo((Voley)equipo);
                    this.listaVoley.Add((Voley)equipo);
                    this.comando.CommandText = "INSERT into Voley (id, nombre, deporte, cantTitulares, cantSuplentes, division, entrenador, cancha, sedeDelEquipo) " +
                        "VALUES (@id, @nombre, @deporte, @cantTitulares, @cantSuplentes, @division, @entrenador, @cancha, @sedeDelEquipo)";
                }
                else if (equipo is Basquet)
                {
                    this.PrepararComandoEquipo((Basquet)equipo);
                    this.listaBasquet.Add((Basquet)equipo);
                    this.comando.CommandText = "INSERT into Basquet (id, nombre, deporte, cantTitulares, cantSuplentes, division, entrenador, equipoMedico, sponsor) " +
                         "VALUES (@id, @nombre, @deporte, @cantTitulares, @cantSuplentes, @division, @entrenador, @equipoMedico, @sponsor)";
                }

                this.comando.Connection = this.coneccion;

                int filasAfectadas = this.comando.ExecuteNonQuery();
                retorno = filasAfectadas;
                if (filasAfectadas == 1)
                {
                    //una vez que se realizo la carga de mis datos actualizo par tener en mis listas locales el id
                    this.ActualizarListas();

                }
            }
            catch (Exception e)
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
        public bool ModificarEquipo(Equipo equipo)
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
                    this.comando.CommandText = "UPDATE Futbol SET nombre = @nombre, deporte = @deporte, cantTitulares = @cantTitulares, cantSuplentes = @cantSuplentes, division = @division,  entrenador = @entrenador," +
                        "colorCamisetaLocal = @colorCamisetaLocal, colorCamisetaVisitante = @colorCamisetaVisitante WHERE id = @id";
                }
                else if (equipo is Voley)
                {
                    this.PrepararComandoEquipo((Voley)equipo);
                    this.comando.CommandText = "UPDATE Voley SET nombre = @nombre, deporte = @deporte, cantTitulares = @cantTitulares, cantSuplentes = @cantSuplentes, division = @division,  entrenador = @entrenador," +
                        "cancha = @cancha, sedeDelEquipo = @sedeDelEquipo WHERE id = @id";
                }
                else if (equipo is Basquet)
                {
                    this.PrepararComandoEquipo((Basquet)equipo);
                    this.comando.CommandText = "UPDATE Basquet SET nombre = @nombre, deporte = @deporte, cantTitulares = @cantTitulares, cantSuplentes = @cantSuplentes, division = @division,  entrenador = @entrenador," +
                        "sponsoDelEquipo = @sponsorDelEquipo, equipoMedico = @equipoMedico WHERE id = @id";
                }

                this.comando.Connection = this.coneccion;
              
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    this.ActualizarListas();
                    retorno = true;
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

        #endregion

        #region Jugador
        public List<Jugador> TraerJugadores()
        {
            List<Jugador> lista = new List<Jugador>();

            this.comando = new SqlCommand();
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "SELECT * FROM Jugador";

            try
            {
                this.comando.Connection = this.coneccion;

                this.coneccion.Open();

                this.lector = this.comando.ExecuteReader();

                while (lector.Read())
                {
                    Jugador jugador = new Jugador();

                    // Asignar atributos del lector al jugador
                    this.AsignarAtributosLectorJugador(jugador);

                    // Agregar jugador a la lista
                    lista.Add(jugador);
                }

                this.lector.Close();
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
            }
            finally 
            {
                if (this.coneccion.State == ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }

            return lista;
        }
        public bool agregarJugadores(List<Jugador> lista)
        {
            bool retorno = true;

            foreach (Jugador jugador in lista)
            {
                if (!this.AgregarJugador(jugador))
                {
                    retorno = false;
                    break;
                }

            }

            return retorno;
        }
        public bool AgregarJugador(Jugador jugador)
        {
            bool retorno = false;

            try
            {
                this.coneccion.Open();
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.PrepararComandoJugador(jugador);
                this.comando.CommandText = "INSERT INTO Jugador (nombre, apellido, idEquipo, genero, dni, edad, division, altura, esTitular, deporte, posicion)   " +
                    "VALUES (@nombre, @apellido, @idEquipo, @genero, @dni, @edad, @division, @altura, @esTitular, @deporte, @posicion);";
                this.comando.Connection = this.coneccion;

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas != 0)
                {
                    // Una vez que se realizó la carga de los datos, actualizo para tener en la lista local el id
                    this.ActualizarListaJugadores();
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                retorno = true;
                // Manejar la excepción si es necesario
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
        public bool ModificarJugador(Jugador jugador)
        {
            bool retorno = false;
           
            try
            {
                this.coneccion.Open();
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.PrepararComandoJugador(jugador);
                this.comando.CommandText = "UPDATE Jugador SET nombre = @nombre, apellido = @apellido, idEquipo = @idEquipo, genero = @genero, " +
                    "dni = @dni, edad = @edad, division = @division, altura = @altura, esTitular = @esTitular, deporte = @deporte, posicion = @posicion " +
                    "WHERE dni = @dni";
                this.comando.Connection = this.coneccion;

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    this.ActualizarListaJugadores();
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
            }
            finally
            {
                if (this.coneccion.State == ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }

            return retorno;
        }// ...
        public bool ModificarJugadores(Equipo equipo)
        {
            bool retorno = true;

            foreach (Jugador jugador in equipo.Jugadores) 
            {
                if(!ModificarJugador(jugador))
                {
                    retorno = false;
                }
            }

            return retorno;
        }
        
        public bool EliminarJugador(Jugador jugador)
        {
            bool retorno = false;

            try
            {
                this.coneccion.Open();
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Parameters.AddWithValue("@dni", jugador.Dni);

                this.comando.CommandText = "DELETE FROM Jugador WHERE dni = @dni";
                this.comando.Connection = this.coneccion;

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    this.ActualizarListaJugadores();
                    retorno = true;
                }
                else if (filasAfectadas == 0)
                {
                    // No se encontró ninguna fila para eliminar
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
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
        public bool EliminarJugadores(Equipo equipo)
        {
            bool retorno = false;

            try
            {
                this.coneccion.Open();
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Parameters.AddWithValue("@idEquipo", equipo.Id);

                this.comando.CommandText = "DELETE FROM Jugador WHERE idEquipo = @idEquipo";
                this.comando.Connection = this.coneccion;

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == equipo.Jugadores.Count)
                {
                    this.ActualizarListaJugadores();
                    retorno = true;
                }
                else if (filasAfectadas == 0)
                {
                    // No se encontró ninguna fila para eliminar
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
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
        public List<Jugador> TraerJugadores(Equipo equipo)
        {
            List<Jugador> lista = new List<Jugador>();

            this.comando = new SqlCommand();
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = $"SELECT * FROM Jugadores Where idEquipo = {equipo.Id}";

            try
            {
                this.comando.Connection = this.coneccion;
                this.coneccion.Open();
                this.lector = this.comando.ExecuteReader();

                while (lector.Read())
                {
                    Jugador jugador = new Jugador();

                    // Asignar atributos del lector al jugador
                    this.AsignarAtributosLectorJugador(jugador);

                    // Agregar jugador a la lista
                    lista.Add(jugador);
                }

                this.lector.Close();
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
            }
            finally
            {
                if (this.coneccion.State == ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }

            return lista;
        }

        #endregion

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
    }
}

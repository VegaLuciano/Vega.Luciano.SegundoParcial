using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Entidades
{
    public class AccesoDatosJugador
    {
        public SqlCommand comando;
        private SqlConnection coneccion;
        private static string connectionString;
        private SqlDataReader lector;
        public List<Jugador> listaJugadores;

        static AccesoDatosJugador()
        {
            AccesoDatosJugador.connectionString = Properties.Resources.miConeccion;
        }

        public AccesoDatosJugador()
        {
            coneccion = new SqlConnection(AccesoDatosJugador.connectionString);
            this.listaJugadores = new List<Jugador>();
            this.ActualizarListaJugadores();
        }

        public void ActualizarListaJugadores()
        {
            this.listaJugadores = this.TraerJugadores();
        }

        public bool ProbarConexion()
        {
            bool retorno = false;

            try
            {
                this.coneccion.Open();
                retorno = true;
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

        public List<Jugador> TraerJugadores()
        {
            List<Jugador> lista = new List<Jugador>();

            this.comando = new SqlCommand();
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "SELECT * FROM Jugadore";

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

        public void AsignarAtributosLectorJugador(Jugador jugador)
        {
            jugador.Nombre = (string)this.lector["nombre"];
            jugador.Apellido = (string)this.lector["apellido"];
            jugador.IdEquipo = (int)this.lector["idEquipo"];
            jugador.Genero = ConvertirStringAEnum<EGenero>((string)this.lector["genero"]);
            jugador.Dni = (int)this.lector["dni"];
            jugador.Edad = (int)this.lector["edad"];
            jugador.Division = ConvertirStringAEnum<EDivisiones>((string)this.lector["division"]);
            jugador.Altura = (double)this.lector["altura"];
            jugador.EsTitular = (bool)this.lector["esTitular"];
            jugador.Deporte = ConvertirStringAEnum<EDeporte>((string)this.lector["deporte"]);
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
                    "VALUES (@nombre, @apellido, @edad, @genero, @dni, @edad, @division, @altura, @esTitular, @deporte, @posicion);";
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
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.PrepararComandoJugador(jugador);
                this.comando.CommandText = "UPDATE Jugador SET nombre = @nombre, apellido = @apellido, idEquipo = @idEquipo, genero = @genero, " +
                    "dni = @dni, edad = @edad, division = @division, altura = @altura, esTitular = @esTitular, deporte = @deporte " +
                    "WHERE dni = @dni";
                this.comando.Connection = this.coneccion;
                this.coneccion.Open();

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

        public bool EliminarJugador(Jugador jugador)
        {
            bool retorno = false;

            try
            {
                this.coneccion.Open();
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Parameters.AddWithValue("@dni", jugador.Dni);

                this.comando.CommandText = "DELETE FROM Jugadores WHERE dni = @dni";
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

    }

}
                

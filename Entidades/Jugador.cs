    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private string nombre;
        private string apellido;
        private int idEquipo;
        private EGenero genero;
        private int dni;
        private int edad;
        private EDivisiones division;
        private double altura;
        private bool esTitular;
        private EDeporte deporte;

        public Jugador() 
        {
            this.idEquipo = -1;
            this.nombre = "None";
            this.apellido= "None";
            this.genero = EGenero.Masculino; 
            this.dni = 0;
            this.division= EDivisiones.Mayores;
            this.edad = 0;
            this.deporte = EDeporte.Futbol;
            this.altura = 0;
        }

        public Jugador(string nombre, string apellido, int edad, EDeporte deporte)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.deporte = deporte;
        }

        public Jugador(string nombre, string apellido,int edad, double altura, int dni, EDivisiones division, EGenero genero, bool esTitular) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.apellido = apellido;
            this.dni = dni;
            this.division = division;
            this.genero = genero;
            this.esTitular = esTitular;
        }

        public Jugador(string nombre, string apellido, int edad, double altura, int dni, EDivisiones division, EGenero genero, bool esTitular, EDeporte deporte) : this(nombre, apellido, edad, altura, dni, division, genero, esTitular)
        {
            this.deporte = deporte;
        }

        #region Propiedades
        public string Nombre
        {
            get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.All(char.IsDigit))
                {
                    nombre = value;
                }
            }
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.All(char.IsDigit))
                {
                    apellido = value;
                }
            }
        }
        public int Dni
        {
            get => dni;
            set
            {
                if (value > 0)
                {
                    dni = value;
                }
            }
        }
        public int Edad
        {
            get => edad;
            set
            {
                if (value >= 0)
                {
                    edad = value;
                }
            }
        }
        public double Altura
        {
            get => altura;
            set
            {
                if (value > 0)
                {
                    altura = value;
                }
            }
        }
        public EDivisiones Division
        {
            get => division; 
            set 
            { 
                if (Jugador.preguntarDivision(this.edad, value))
                    division = value;
            }
        }

        public EDeporte Deporte { get => deporte; set => deporte = value;  }
        public EGenero Genero { get => genero; set => genero = value; }
        public bool EsTitular { get => esTitular; set => esTitular = value; }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }

        #endregion

        public static bool operator ==(Jugador jugador1, Jugador jugador2) 
        {
            return jugador1.dni == jugador2.dni;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1.dni == jugador2.dni);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Jugador && obj != null)
                retorno = this == (Jugador)obj;

            return retorno;
        }

        /// <summary>
        /// Pregunta si la division que quiere asignarse esta bien de acuerdo a la edad
        /// </summary>
        /// <param name="edad"></param>
        /// <returns></returns> true si se puede asignar la division o false de caso contrario
        private static bool preguntarDivision(int edad, EDivisiones division)
        {
            bool retorno = true;
            switch (division)
            {
                case EDivisiones.Sub16:
                    if (edad > 16)
                        retorno = false;
                    break;
                case EDivisiones.Sub18:
                    if (edad > 18)
                        retorno = false;
                    break;
                case EDivisiones.Sub21:
                    if (edad > 21)
                        retorno = false;
                    break;
                case EDivisiones.Mayores:
                    retorno = true;
                    break;
            }
            return retorno;
        }

        private string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre - { this.nombre}");
            sb.AppendLine($"Apellido - {this.apellido}");
            sb.AppendLine($"Edad - {this.edad}");
            sb.AppendLine($"Altura - {this.altura:0.00}");
            sb.AppendLine($"Dni - {this.dni}");
            sb.AppendLine($"Division - {this.division}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}

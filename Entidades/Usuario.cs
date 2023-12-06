using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Usuario
    {
        private string id;
        private string nombre;
        private string apellido;
        private string mail;
        private string contraseña;
        private static int countId;

        public delegate void UsuarioDelegate(Usuario sender, InfoUsuariosEventArgs info);

        public event UsuarioDelegate usuarioAnotado;

        public Usuario()
        {
            this.nombre = "None";
            this.id += countId;
            Usuario.countId++;
            this.contraseña = "None";
            this.apellido = "None";
            this.mail = "None";
        }
        public Usuario(string mail, string contraseña) : this()
        {
            this.mail = mail;
            this.contraseña = contraseña;   
        }

        public Usuario(string mail, string contraseña, string nombre, string apellido) : this(mail, contraseña)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public static bool operator ==(Usuario usuario1, Usuario usuario2)
        {
            return usuario1.mail == usuario2.mail && usuario1.contraseña == usuario2.contraseña;
        }
        public static bool operator !=(Usuario usuario1, Usuario usuario2)
        {
            return !(usuario1 == usuario2);
        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Usuario && obj != null)
                retorno = this == (Usuario)obj;

            return retorno;
        }
        /// <summary>
        /// Valida que la contraseña sea lo suficientemente segura
        /// </summary>
        /// <param name="contraseña"></param>
        /// <returns>retorna un entero con el cual se informara que necesita la contraseña para ser segura</returns>
        public static int ValidarContraseña(string contraseña) 
        {
            int retorno = 0;

            if (contraseña.Length < 6)
            {
                retorno = 1;
            }

            if (!contraseña.Any(char.IsUpper))
            {
                retorno = 2;
            }

            if (!contraseña.Any(char.IsDigit))
            {
                retorno = 3;
            }

            if (!contraseña.Any(c => !char.IsLetterOrDigit(c)))
            {
                retorno = 4;
            }

            return retorno;
        }

        /// <summary>
        /// Busca al usuario en la lista 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="lista"></param>
        /// <returns>Si el usuario esta retorna su pocision, de caso contrario 0</returns>
        public static int FindUser(Usuario usuario, List<Usuario> lista)
        {
            int index = -1;
            foreach (Usuario user in lista)
            {
                if (user == usuario) 
                {
                    index = lista.IndexOf(user);
                    break;
                }
            }

            if (index == -1)
            {
                throw new ExcepcionUsuarioInexistente($"El usuario {usuario} no existe en la lista.");
            }

            return index;
        }

        public void guardarUsuario(Usuario usuario, string path, DateTime fecha) 
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                {
                    sw.WriteLine(usuario.ToString());
                    sw.WriteLine("  " + fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                }

                usuarioAnotado?.Invoke(this, new InfoUsuariosEventArgs(fecha));

            }
            catch (Exception ex)
            { 
                
            }
            
        }

        public static bool CampoRepetido(string usuario, List<Usuario> lista)
        {
            bool retorno = false;
            foreach (Usuario user in lista)
            {
                if (user.mail == usuario)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        private string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.id} - {this.nombre} - {this.mail}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}

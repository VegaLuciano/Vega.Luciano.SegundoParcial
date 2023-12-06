using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionUsuarioInexistente : Exception
    {
        public string mensaje { get; }
        public string detalles { get; }

        public ExcepcionUsuarioInexistente(string detalles) : base(detalles)
        {
            this.mensaje = "Error, contraseña o mail incorrectos";

            this.detalles = detalles;

        }
    }

    public class ExcepcionesBD : Exception
    {
        public string mensaje { get; }
        public string detalles { get; }

        public ExcepcionesBD(string detalles) : base(detalles)
        {
            this.mensaje = "Ocurrio un error con la base de datos";

            this.detalles = detalles;

        }
    }
}

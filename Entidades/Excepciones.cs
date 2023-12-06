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
            this.mensaje = "Ha Ocurrido Un error con la Base de Datos";

            this.detalles = detalles;

        }
    }
}

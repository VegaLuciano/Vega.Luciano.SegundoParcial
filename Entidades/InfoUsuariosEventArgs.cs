using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InfoUsuariosEventArgs : EventArgs
    {
        public DateTime fecha { get; }

        public InfoUsuariosEventArgs(DateTime fecha)
        {
            this.fecha = fecha;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RelojEventArgs : EventArgs
    {
        public DateTime horaActual { get; }
        public RelojEventArgs(DateTime hora)
        {
            this.horaActual = hora;
        }
    }
}
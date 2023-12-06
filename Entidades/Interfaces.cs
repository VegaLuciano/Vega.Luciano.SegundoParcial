﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IEquipoConFormacion
    {
        public void DeterminarPosiciones();
    }

    public interface IJugadorConCategoria
    {
        public string Posicion { get; set; }
    }
}
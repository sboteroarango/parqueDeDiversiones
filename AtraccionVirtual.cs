﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDiversiones
{
    class AtraccionVirtual:Atraccion
    {
        public AtraccionVirtual(string codigo, string nombre, int limite_edad, float limite_estatura, int costo) : base(codigo, nombre, limite_edad, limite_estatura, costo)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
    class AtraccionAcuatica:Atraccion
    {
        public AtraccionAcuatica(string codigo, string nombre, int limite_edad, float limite_estatura, int costo) : base(codigo, nombre, limite_edad, limite_estatura, costo)
        {

        }
        public override string GenerarStringConInfoDeAtraccion(Atraccion atraccion)
        {
            return base.GenerarStringConInfoDeAtraccion(atraccion);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDiversiones
{
    class AtraccionVirtual:Atraccion
    {
        public AtraccionVirtual(string codigo, string nombre, int limite_edad, float limite_estatura, int costo, int cantidad_ingresos, List<Usuario> usuarios_recibidos) : base(codigo, nombre, limite_edad, limite_estatura, costo, cantidad_ingresos, usuarios_recibidos)
        {

        }
    }
}

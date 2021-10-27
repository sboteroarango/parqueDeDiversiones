using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
    class AtraccionMecanica:Atraccion
    {
        public AtraccionMecanica(string codigo, string nombre, int limite_edad, float limite_estatura, int costo) : base (codigo, nombre,  limite_edad,  limite_estatura,  costo)
        {

        }
        public override string GenerarStringConInfoDeAtraccion(Atraccion atraccion)
        {
            return base.GenerarStringConInfoDeAtraccion(atraccion);
        }

        public override void SerUsada(Manilla manilla)
        {
            if (manilla.Edad >= Limite_edad &&  manilla.Saldo >= Costo && manilla.Estatura >= Limite_estatura)
            {
                //puede ingresar:
                // crear metodo que cuenta cuantas veces a ingresado a una atracción
                //se crea una entrada, se agrega esa entrada en el que el costo de la entrada va a variar 
                // si el usuario ha ingresado más de 2 veces a esta mecánica, se le da un descuento del 8%
                //a esa manilla se le resta ese costo
            }
            else
            {
                Console.WriteLine("no tiene permitido el ingreso");
            }
        }

    }
}

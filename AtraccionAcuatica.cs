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

        public override void SerUsada(Manilla manilla)
        {
            if (manilla.Edad >= Limite_edad &&  manilla.Saldo >= Costo && manilla.Estatura >= Limite_estatura)
            {
                //puede ingresar:
                if (manilla.Edad>= 45 && manilla.Edad <=50)
                {
                    Entrada entrada = new Entrada((int)(this.Costo-(this.Costo*7/100)),manilla);
                    this.Entradas.Add(entrada);
                    manilla.Saldo -= (int)(this.Costo-(this.Costo*7/100));

                }else
                {
                    Entrada entrada = new Entrada(this.Costo,manilla);
                    this.Entradas.Add(entrada);
                    manilla.Saldo -= this.Costo;

                }
                //se crea una entrada, se agrega esa entrada en el que el costo de la entrada va a variar 
                // si el usuario está entre 45 y 50 años, se le da un descuento del 7% en la atracción acúatica
                //a esa manilla se le resta ese costo
            }
            else
            {
                Console.WriteLine("no tiene permitido el ingreso");
            }
        }
    }
}

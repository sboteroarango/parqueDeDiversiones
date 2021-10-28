using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
    class AtraccionVirtual:Atraccion
    {
        public AtraccionVirtual(string codigo, string nombre, int limite_edad, float limite_estatura, int costo) : base(codigo, nombre, limite_edad, limite_estatura, costo)
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
                int cantidadDeVecesIngresadasDeManilla = 0;
                foreach (Entrada entrada in this.Entradas)
                {
                    if(entrada.Manilla == manilla)
                    {
                        cantidadDeVecesIngresadasDeManilla += 1;
                    }
                    
                }
                
                if(this.Costo <= 15000 && cantidadDeVecesIngresadasDeManilla>2)
                {
                    Entrada entrada = new Entrada((int)(this.Costo+(this.Costo*5/100)),manilla);
                    this.Entradas.Add(entrada);
                    manilla.Saldo -= (int)(this.Costo+(this.Costo*5/100));
                }
            }
            else
            {
                Console.WriteLine("no tiene permitido el ingreso");
            }
        }
    }
}

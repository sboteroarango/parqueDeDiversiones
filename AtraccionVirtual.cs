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
        public override string GenerarStringConInfoDeAtraccion( )
        {
            return base.GenerarStringConInfoDeAtraccion();
        }

        public override void SerUsada(Manilla manilla)
        {
            if (manilla.Edad >= this.Limite_edad &&  manilla.Saldo >= this.Costo && manilla.Estatura >= this.Limite_estatura)
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
                else
                {
                    Entrada entrada = new Entrada(this.Costo,manilla);
                    this.Entradas.Add(entrada);
                    manilla.Saldo -= this.Costo;

                }
            }
            else
            {
                Console.WriteLine("no tiene permitido el ingreso");
            }
        }
        public override void GenerarReporte()
        {
            base.GenerarReporte();
        }
    }
}

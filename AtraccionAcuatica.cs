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
        public override string GenerarStringConInfoDeAtraccion( )
        {
            return base.GenerarStringConInfoDeAtraccion();
        }

        public override void SerUsada(Manilla manilla)
        {
            if (manilla.Edad >= this.Limite_edad &&  manilla.Saldo >= this.Costo && manilla.Estatura >= this.Limite_estatura)
            {
            
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
            }
            else
            {
                Console.WriteLine("no tiene permitido el ingreso");
            }
        }
    }
}

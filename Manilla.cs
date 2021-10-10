using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDiversiones
{
    class Manilla
    {
        private int saldo;

        public Manilla(int saldo)
        {
            this.saldo = saldo;
        }

        public int Saldo { get => saldo; set => saldo = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDiversiones
{
    class Sistema
    {
        private List<Atraccion> atracciones_recibidas;

        public Sistema(List<Atraccion> atracciones_recibidas)
        {
            this.atracciones_recibidas = atracciones_recibidas;
        }

        internal List<Atraccion> Atracciones_recibidas { get => atracciones_recibidas; set => atracciones_recibidas = value; }
    }
}

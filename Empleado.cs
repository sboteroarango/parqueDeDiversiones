using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDiversiones
{
    class Empleado
    {
        private string id;
        private string nombre_completo;
        private Atraccion atraccion_manejada;

        public Empleado(string id, string nombre_completo, Atraccion atraccion_manejada)
        {
            this.id = id;
            this.nombre_completo = nombre_completo;
            this.atraccion_manejada = atraccion_manejada;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        internal Atraccion Atraccion_manejada { get => atraccion_manejada; set => atraccion_manejada = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDiversiones
{
    class Usuario
    {
        private int edad;
        private float estatura;
        private string nombre_completo;
        private List<Atraccion> atracciones_usadas;
        private Manilla manilla;

        public Usuario(int edad, float estatura, string nombre_completo, List<Atraccion> atracciones_usadas, Manilla manilla)
        {
            this.edad = edad;
            this.estatura = estatura;
            this.nombre_completo = nombre_completo;
            this.atracciones_usadas = atracciones_usadas;
            this.manilla = manilla;
        }

        public int Edad { get => edad; set => edad = value; }
        public float Estatura { get => estatura; set => estatura = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        internal List<Atraccion> Atracciones_usadas { get => atracciones_usadas; set => atracciones_usadas = value; }
        internal Manilla Manilla { get => manilla; set => manilla = value; }
    }
}

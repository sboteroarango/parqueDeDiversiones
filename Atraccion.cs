using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDiversiones
{
    abstract class Atraccion
    {
        private string codigo;
        private string nombre;
        private int limite_edad;
        private float limite_estatura;
        private int costo;
        private int cantidad_ingresos;
        private List<Usuario> usuarios_recibidos;

        public Atraccion(string codigo, string nombre, int limite_edad, float limite_estatura, int costo, int cantidad_ingresos, List<Usuario> usuarios_recibidos)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.limite_edad = limite_edad;
            this.limite_estatura = limite_estatura;
            this.costo = costo;
            this.cantidad_ingresos = cantidad_ingresos;
            this.usuarios_recibidos = usuarios_recibidos;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Limite_edad { get => limite_edad; set => limite_edad = value; }
        public float Limite_estatura { get => limite_estatura; set => limite_estatura = value; }
        public int Costo { get => costo; set => costo = value; }
        public int Cantidad_ingresos { get => cantidad_ingresos; set => cantidad_ingresos = value; }
        internal List<Usuario> Usuarios_recibidos { get => usuarios_recibidos; set => usuarios_recibidos = value; }
    }
}

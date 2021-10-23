using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
    class Atraccion
    {
        private string codigo;
        private string nombre;
        private int limite_edad;
        private float limite_estatura;
        private int costo;
        private List<Entrada> entradas = new List<Entrada>();
      
       

        public Atraccion(string codigo, string nombre, int limite_edad, float limite_estatura, int costo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.limite_edad = limite_edad;
            this.limite_estatura = limite_estatura;
            this.costo = costo;
           
           
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Limite_edad { get => limite_edad; set => limite_edad = value; }
        public float Limite_estatura { get => limite_estatura; set => limite_estatura = value; }
        public int Costo { get => costo; set => costo = value; }

        public virtual string GenerarStringConInfoDeAtraccion(Atraccion atraccion)
        {
            return ($"Su codigo es {atraccion.Codigo}, Su nombre es {atraccion.Nombre}, su limite de edad es {atraccion.Limite_edad}, su limite de estatura es {atraccion.Limite_estatura} y su costo es {atraccion.Costo}");
        }
      
        
    }
}
//generar un reporte de costos en cualquier momento del día,, Ver la información del usuario (incluye ver la lista de atracciones a las cuales ha ingresado el usuario y el saldo de la manilla). (Simón)
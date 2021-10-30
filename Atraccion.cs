using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
    abstract class Atraccion
    {
        private string codigo;
        private string nombre;
        private int limite_edad;
        private float limite_estatura;
        private int costo;
        private List<Entrada> entradas = new List<Entrada>();
      
       public Atraccion()
        {

        }

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
        public List<Entrada> Entradas { get => entradas; }

        public virtual string GenerarStringConInfoDeAtraccion()
        {
            return ($"\nSu codigo es {this.Codigo}, su nombre es {this.Nombre}, su limite de edad es {this.Limite_edad} años, su limite de estatura es {this.Limite_estatura}cm y su costo para entrar es de ${this.Costo} pesos. \n");
        }

        public abstract void SerUsada(Manilla manilla);

        public virtual void GenerarReporte()
        {
            int ingresos = 0;
            foreach (Entrada entrada in this.Entradas)
            {
                ingresos += entrada.Costo;
            }
            DateTime ahora = DateTime.Now;
            TextWriter escritor = new StreamWriter("reporte.txt",append:true);
            escritor.WriteLine($"fecha : {ahora.ToString("F")}\natraccion : {this.Nombre}\ncantidad de entradas : {(this.Entradas).Count}\ningresos : {ingresos} pesos\n");
            escritor.Close();

        }
    }
}
//generar un reporte de costos en cualquier momento del día,, Ver la información del usuario (incluye ver la lista de atracciones a las cuales ha ingresado el usuario y el saldo de la manilla). (Simón)registro con el número de ingresos en el día, ingresos por atracción, ingresos económicos por atracción y ingresos económicos totales.
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
    class Manilla
    {
        private int edad;
        private float estatura;
        private string nombre_completo;
        private int saldo;
       


        public Manilla(int edad, float estatura, string nombre_completo,int saldo)
        {
            this.edad = edad;
            this.estatura = estatura;
            this.nombre_completo = nombre_completo;
            this.saldo = saldo;
          
        }

        public int Edad { get => edad; set => edad = value; }
        public float Estatura { get => estatura; set => estatura = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public int Saldo {get => saldo; set => saldo = value;}
        
       
    }
}

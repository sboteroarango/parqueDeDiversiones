using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
    class ParqueDiversiones
    {
        static void Main(string[] args)
        {
            List<Atraccion> listaAtracciones = AdministradorArchivos.generarAtracciones();
           
            Console.WriteLine(listaAtracciones[0].Limite_estatura);
         
            
        }
    }
}

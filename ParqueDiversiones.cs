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
            List<AtraccionMecanica> listaAtracciones = AdministradorArchivos.generarAtraccionesMecanicas();
            List<AtraccionAcuatica> listaAtracciones1 = AdministradorArchivos.generarAtraccionesAcuaticas();
            List<AtraccionVirtual> listaAtracciones2 = AdministradorArchivos.generarAtraccionesVirtuales();
           
            Console.WriteLine(listaAtracciones[0].Limite_estatura);
         
            
        }
    }
}

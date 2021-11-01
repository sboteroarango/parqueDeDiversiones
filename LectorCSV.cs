using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ParqueDiversiones
{
    class LectorCSV : ILector
    {

        public List<AtraccionMecanica> LeerMecanica()
        {
            string[] lines = File.ReadAllLines("AtraccionesMecanicas.csv");
            List<AtraccionMecanica> listaDeAtracciones = new List<AtraccionMecanica>();
            foreach (string line in lines)
            {
                string[] listaCreada = line.Split(';');
                AtraccionMecanica atraccion = new AtraccionMecanica(listaCreada[0], listaCreada[1], Convert.ToInt32(listaCreada[2]), float.Parse(listaCreada[3] + "," + listaCreada[4]), Convert.ToInt32(listaCreada[5]));
                listaDeAtracciones.Add(atraccion);
            }
            return listaDeAtracciones;
        }
        public List<AtraccionAcuatica> LeerAcuatica()
        {
            string[] lines = File.ReadAllLines("AtraccionesAcuaticas.csv");
            List<AtraccionAcuatica> listaDeAtracciones = new List<AtraccionAcuatica>();
            foreach (string line in lines)
            {
                string[] listaCreada = line.Split(';');
                AtraccionAcuatica atraccion = new AtraccionAcuatica(listaCreada[0], listaCreada[1], Convert.ToInt32(listaCreada[2]), float.Parse(listaCreada[3] + "," + listaCreada[4]), Convert.ToInt32(listaCreada[5]));
                listaDeAtracciones.Add(atraccion);
            }
            return listaDeAtracciones;
        }
        public List<AtraccionVirtual> LeerVirtual()
        {
            string[] lines = File.ReadAllLines("AtraccionesVirtuales.csv");
            List<AtraccionVirtual> listaDeAtracciones = new List<AtraccionVirtual>();
            foreach (string line in lines)
            {
                string[] listaCreada = line.Split(';');
                AtraccionVirtual atraccion = new AtraccionVirtual(listaCreada[0], listaCreada[1], Convert.ToInt32(listaCreada[2]), float.Parse(listaCreada[3] + "," + listaCreada[4]), Convert.ToInt32(listaCreada[5]));
                listaDeAtracciones.Add(atraccion);
            }
            return listaDeAtracciones;
        }







    }
}

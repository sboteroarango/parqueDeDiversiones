using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
	class AdministradorArchivos
	{
        //TODO hacer que lines si se lea bien
        public static List<Atraccion> generarAtraccionesDeTipo(string tipo)
        {
            switch(tipo)
            {
                case "AC" :
                {
                    string[] lines = File.ReadAllLines("textoAtraccionesAcuaticas.txt");
                    break;
                }
                case "MC" :
                {
                    string[] lines = File.ReadAllLines("textoAtraccionesMecanicas.txt");
                    break;
                }
                case "VI" :
                {
                    string[] lines = File.ReadAllLines("textoAtraccionesVirtuales.txt");
                    break;
                }
            }
            List<Atraccion> listaDeAtracciones = new List<Atraccion>();
            foreach (string line in lines)
            {
                string[] listaCreada = line.Split(',');
                Atraccion atraccion = new Atraccion(listaCreada[0],listaCreada[1],Convert.ToInt32(listaCreada[2]),float.Parse(listaCreada[3]+","+listaCreada[4]),Convert.ToInt32(listaCreada[5]));
                listaDeAtracciones.Add(atraccion);
            }
            return listaDeAtracciones;

        }

        


	}
}
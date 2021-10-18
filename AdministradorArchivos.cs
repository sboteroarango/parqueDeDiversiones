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
        public static List<Atraccion> generarAtracciones()
        {
            //TODO hacer que esto lo haga con cada tipo de atraccion
            string[] lines = File.ReadAllLines("textoAtracciones.txt");
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
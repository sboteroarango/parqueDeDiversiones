using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace ParqueDiversiones
{
	class Entrada
	{
		private int costo;
		private List<Manilla> manillas= new List<Manilla>();

		public Entrada()
		{

		}

		public int Costo{ get => costo; set => costo=value;}
		private List<Manilla> Manillas{get => manillas; set => manillas=value;}


	}
}

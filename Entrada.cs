using System;

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

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
		Manilla manilla;
	      

		public Entrada()
		{

		}
		public Entrada(int costo,Manilla manilla)
		{
			this.costo = costo;
			this.manilla = manilla;

		}

		public int Costo{ get => costo; set => costo=value;}
		private Manilla Manilla{ get => manilla; set => manilla=value;}


	}
}

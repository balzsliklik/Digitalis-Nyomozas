using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Person
	{
		private string nev;
		private int eletkor;
		private string megjedzes;

		public Person(string nev, int eletkor, string megjedzes)
		{
			this.nev = nev;
			this.eletkor = eletkor;
			this.megjedzes = megjedzes;
		}
		
		public string Nev { get => nev; set => nev = value; }
		public int Eletkor { get => eletkor; set => eletkor = value; }
		public string Megjedzes { get => megjedzes; set => megjedzes = value; }
	
	}
}

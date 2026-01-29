using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Suspect
	{
		private Person person;
		private int gyanusitottSzint;
		private string statusz;

		public Suspect(Person person, int gyanusitottSzint, string statusz) { 
			this.person = person;
			this.gyanusitottSzint = gyanusitottSzint;
			this.statusz = statusz;
		}

		public int GyanusitottSzint { get => gyanusitottSzint; set => gyanusitottSzint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Person Person { get => person; set => person = value; }
	}
}

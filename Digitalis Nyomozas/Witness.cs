using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Witness
	{
		private Person person;
		private string vallomasSzovege;
		private DateTime vallomasDatuma;

		public Witness(Person person, string vallomasSzovege, DateTime vallomasDatuma) { 
			this.person = person;
			this.vallomasSzovege = vallomasSzovege;	
			this.vallomasDatuma = vallomasDatuma;

		}

		public string VallomasSzovege { get => vallomasSzovege; set => vallomasSzovege = value; }
		public DateTime VallomasDatuma { get => vallomasDatuma; set => vallomasDatuma = value; }
		internal Person Person { get => person; set => person = value; }
	}
}

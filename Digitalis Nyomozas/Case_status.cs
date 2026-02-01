using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Case_status
	{
		private string aktualisStatusz;

		public Case_status(string aktualisStatusz) { 
			this.aktualisStatusz = aktualisStatusz;
		}
        public Case_status()
        {
            this.aktualisStatusz = "aktív";
        }

        public string AktualisStatusz { get => aktualisStatusz; set => aktualisStatusz = value; }

		public void ChangeStats(string newStatus)
		{
			aktualisStatusz = newStatus;
		}

        public override string ToString()
        {
			return aktualisStatusz;
        }
    }
}

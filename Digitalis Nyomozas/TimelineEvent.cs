using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class TimelineEvent
	{
		private DateTime datum;
		private string esemenyLeiras;

		public DateTime Datum { get => datum; set => datum = value; }
		public string EsemenyLeiras { get => esemenyLeiras; set => esemenyLeiras = value; }

		public TimelineEvent(DateTime datum, string esemenyLeiras)
		{
			this.datum = datum;
			this.esemenyLeiras = esemenyLeiras;
		}
	}
}

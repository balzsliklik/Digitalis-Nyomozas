using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class EvidenceManager
	{
		private List<Evidence> bizonyitekok;

		public EvidenceManager()
		{
			bizonyitekok = new List<Evidence>();
		}

        internal List<Evidence> Bizonyitekok { get => bizonyitekok; }

		public void AddEvidence(Evidence e)
		{
			bizonyitekok.Add(e);
		}
		public void RemoveEvidence(Evidence e)
		{
			bizonyitekok.Remove(e);
		}

		public List<Evidence> ListEvidence()
		{
			return bizonyitekok;
		}
    }
}

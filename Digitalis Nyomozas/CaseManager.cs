using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class CaseManager
	{
		private List<Case> ugyek;

        internal List<Case> Ugyek { get => ugyek; }

		public CaseManager()
		{
			ugyek = new List<Case>();
		}

		public void CreateCase(Case c)
		{
			ugyek.Add(c);
		}
		public void AddPersonToCase(int caseId, Person p)
		{
            var c = ugyek.Find(x => x.Azonosito == caseId);
            if (c != null)
                c.AddPerson(p);
        }

        public void AddEvidenceToCase(int caseId, Evidence e)
        {
            var c = ugyek.Find(x => x.Azonosito == caseId);
            if (c != null)
                c.AddEvidence(e);
        }


    }
}

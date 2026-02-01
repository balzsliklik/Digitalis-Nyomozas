using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
    internal class Case
    {
        private int azonosito;
        private string cim;
        private string leiras;
        private Case_status status;
        private List<Person> szemelyek;
        private List<Evidence> bizonyitekok;
        private List<Case> kapcsolodoUgyek;
        private List<TimelineEvent> idovonal;

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        internal Case_status Status { get => status; set => status = value; }
        internal List<Person> Szemelyek { get => szemelyek; }
        internal List<Evidence> Bizonyitekok { get => bizonyitekok; }
        internal List<Case> KapcsolodoUgyek { get => kapcsolodoUgyek; }
        internal List<TimelineEvent> Idovonal { get => idovonal; }

        public Case(int azonosito, string cim, string leiras)
        {
            this.azonosito = azonosito;
            this.cim = cim;
            this.leiras = leiras;
            this.status = new Case_status();
            this.szemelyek = new List<Person>();
            this.bizonyitekok = new List<Evidence>();
            this.kapcsolodoUgyek = new List<Case>();
            this.idovonal = new List<TimelineEvent>();
        }

        public void AddPerson(Person p)
        {
            szemelyek.Add(p);
        }

        public void AddEvidence(Evidence e)
        {
            if (status.AktualisStatusz != "lezárt")
                bizonyitekok.Add(e);
        }

        public void AddTimelineEvent(TimelineEvent timelineEvent)
        {
            idovonal.Add(timelineEvent);
        }

        public override string ToString()
        {
            return $"{cim} (ID: {azonosito}) - Állapot: {status}";
        }
    }
}

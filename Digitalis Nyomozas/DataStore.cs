using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class DataStore
	{
        private List<User> felhasznalok;
        private List<Case> ugyek;
        private List<Person> szemelyek;
        private List<Evidence> bizonyitekok;

        internal List<User> Felhasznalok { get => felhasznalok; }
        internal List<Case> Ugyek { get => ugyek; }
        internal List<Person> Szemelyek { get => szemelyek; }
        internal List<Evidence> Bizonyitekok { get => bizonyitekok;}

        public DataStore()
        {
            felhasznalok = new List<User>();
            ugyek = new List<Case>();
            szemelyek = new List<Person>();
            bizonyitekok = new List<Evidence>();
        }

        public void AddUser(User user)
        {
            felhasznalok.Add(user);

        }
        public void AddCase(Case c)
        {
            ugyek.Add(c);
        }
        public void AddPerson(Person p)
        {
            szemelyek.Add(p);
        }
        public void AddEvidence(Evidence e)
        {
            bizonyitekok.Add(e);
        }
    }
}

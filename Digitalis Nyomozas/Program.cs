using System.ComponentModel.Design;

namespace Digitalis_Nyomozas
{
    internal class Program
    {
        static CaseManager caseManager = new CaseManager();
        static DataStore ds = new DataStore();
        static DecisionEngine decisionEngine = new DecisionEngine();
        static EvidenceManager evidenceManager = new EvidenceManager();


        static string[] menu = { "Ügyek kezelése", "Személyek kezelése", "Bizonyítékok kezelése", "Bizonyítékok kezelése", "Idővonal megtekintése", "Elemzés / döntések", "Kilépés" };


        static void ugykezeles()
        {
            Console.Clear();
            bool fut = true;

            while (fut)
            {
                Console.WriteLine(menu[0]);
                Console.WriteLine("\n1. Listázas\n2. Ügy hozzáadása\n3.Vissza");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < 1 || input > 3)
                {
                    Console.WriteLine("rossz input");
                }
                else
                {
                    if (input == 1)
                    {
                        caseManager.ListCase();
                        Console.WriteLine("\n Folalyatatás [ENTER]");
                        fut = false;
                    }
                    else if (input == 2)
                    {
                        Console.Clear();
                        Console.Write("add meg az azonosítót: ");
                        int azonosito = Convert.ToInt32(Console.ReadLine());
                        Console.Write("add meg a címet: ");
                        string cim = Console.ReadLine();
                        Console.Write("add meg a leírást: ");
                        string leiras = Console.ReadLine();

                        caseManager.CreateCase(new Case(azonosito, cim, leiras));

                        Console.WriteLine("ugy hozzáadva.\n folytatás [ENTER]");
                        Console.ReadLine();
                        fut = false;
                    }
                    else if (input == 3)
                    {
                        fut = false;
                    }

                }

            }
        }
        static void szemelyhozzaad()
        {
            Console.Clear();
            Console.WriteLine("Személy hozzaadása ügyhöz\n");
            Console.Write("ügy azaonsítószáma: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("személy neve: ");
            string nev = Console.ReadLine();
            Console.Write("személy kora: ");
            int eletkor = Convert.ToInt32(Console.ReadLine());
            Console.Write("személyről megjedzés: ");
            string megjedzes = Console.ReadLine();

            caseManager.AddPersonToCase(id, new Person(nev, eletkor, megjedzes));
            Console.WriteLine("\nszemély hozzáadva.\n\nFolyataás [ENTER]");
        }
        static void bizonyitek() 
        {
            bool fut = true;
            while (fut)
            {
				Console.WriteLine("""
                1. Bizoníték listázása
                2. Bizonyíték hozzaadása
                3. Bizonyíték törlése
                4. Vissza
                """);
				int input = Convert.ToInt32(Console.ReadLine());
				
                if (input < 1 || input > 3)
                {
                    Console.WriteLine("hibás input");
                }
                else
                {
                    if(input == 1)
                    {
                        Console.WriteLine(evidenceManager.ListEvidence());
                        Console.WriteLine("\nFolytatás [ENTER]");
                        Console.ReadLine();
                        fut = false;
                    }else if (input == 2)
                    {
                        Console.Write("add meg az azonosítot: ");
                        int azonosito = Convert.ToInt32(Console.ReadLine());
                        Console.Write("add meg a típust(fotó, dokumentum, digitális adat): ");
                        string tipus = Console.ReadLine();
                        Console.Write("add meg a leírást: ");
                        string leiras = Console.ReadLine();
                        Console.Write("add meg a megbízhatósagi értéket(1-5): ");
                        int megbizhatosag = Convert.ToInt32(Console.ReadLine());


                        evidenceManager.AddEvidence(new Evidence(azonosito, tipus, leiras, megbizhatosag));


                    }else if (input == 3)
                    {
                        int index = 0;
                        foreach (Evidence i in evidenceManager.ListEvidence())
                        {
                            index++;
                            Console.WriteLine(index+" "+i);
                        }
                    }
                }
			}
            
        }
        static void Main(string[] args)
        {
            Console.Clear();

                //Case ugy1 = new Case()



                bool program = true;
                while (program == true)
                {
                    Console.WriteLine("""

                1. Ügyek kezelése 
                2. Személyek kezelése 
                3. Bizonyítékok kezelése 
                4. Idővonal megtekintése 
                5. Elemzés / döntések 
                6. Kilépés
                """);
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == 6)
                    {
                        program = false;
                    }
                    else
                    {
                        if (input > 6 || input < 1)
                        {
                            Console.WriteLine("rossz input!");
                        }
                        if (input == 1)
                        {
                            ugykezeles();
                        }
                        else if (input == 2)
                        {
                        szemelyhozzaad();

                        }
                        else if (input == 3)
                        {

                        }
                        else if (input == 4)
                        {

                        }
                        else if (input == 5)
                        {

                        }
                    }
                }


            
        }
    }
}

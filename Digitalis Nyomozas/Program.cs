using System.ComponentModel.Design;

namespace Digitalis_Nyomozas
{
    internal class Program
    {
        static CaseManager caseManager = new CaseManager();
        static DataStore ds = new DataStore();
        static DecisionEngine decisionEngine = new DecisionEngine();
        static EvidenceManager evidenceManager = new EvidenceManager();

        static string[] menu = { "Ügyek kezelése", "Személyek kezelése", "Bizonyítékok kezelése", "Idővonal megtekintése", "Elemzés / döntések", "Kilépés" };

        static void ugykezeles()
        {
            Console.Clear();
            bool fut = true;

            while (fut)
            {
                Console.WriteLine($"--- {menu[0]} ---");
                Console.WriteLine("\n1. Listázás\n2. Ügy hozzáadása\n3. Vissza");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    
                    foreach (var u in caseManager.Ugyek) Console.WriteLine(u);
                    Console.WriteLine("\nNyomj ENTER-t a folytatáshoz...");
                    Console.ReadLine();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Console.Write("Add meg az azonosítót: ");
                    int azonosito = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg a címet: ");
                    string cim = Console.ReadLine();
                    Console.Write("Add meg a leírást: ");
                    string leiras = Console.ReadLine();

                    caseManager.CreateCase(new Case(azonosito, cim, leiras));

                    Console.WriteLine("Ügy hozzáadva. [ENTER]");
                    Console.ReadLine();
                }
                else if (input == 3)
                {
                    fut = false;
                }
            }
        }

        static void szemelyhozzaad()
        {
            Console.Clear();
            Console.WriteLine($"--- {menu[1]} ---");
            Console.Write("Ügy azonosítószáma: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Személy neve: ");
            string nev = Console.ReadLine();
            Console.Write("Személy kora: ");
            int eletkor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Személyről megjegyzés: ");
            string megjedzes = Console.ReadLine();

            caseManager.AddPersonToCase(id, new Person(nev, eletkor, megjedzes));
            Console.WriteLine("\nSzemély hozzáadva. [ENTER]");
            Console.ReadLine();
        }

        static void bizonyitek()
        {
            Console.Clear();
            bool fut = true;
            while (fut)
            {
                Console.WriteLine($"--- {menu[2]} ---");
                Console.WriteLine("1. Bizonyíték listázása");
                Console.WriteLine("2. Bizonyíték hozzáadása");
                Console.WriteLine("3. Bizonyíték törlése");
                Console.WriteLine("4. Vissza");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    foreach (var e in evidenceManager.ListEvidence())
                    {
                        Console.WriteLine(e);
                    }
                    Console.WriteLine("\nNyomj ENTER-t a folytatáshoz...");
                    Console.ReadLine();
                }
                else if (input == 2)
                {
                    Console.Write("Azonosító: ");
                    int azonosito = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Típus (fotó, dokumentum, digitális adat): ");
                    string tipus = Console.ReadLine();
                    Console.Write("Leírás: ");
                    string leiras = Console.ReadLine();
                    Console.Write("Megbízhatóság (1-5): ");
                    int megbizhatosag = Convert.ToInt32(Console.ReadLine());

                    evidenceManager.AddEvidence(new Evidence(azonosito, tipus, leiras, megbizhatosag));
                    Console.WriteLine("Bizonyíték rögzítve.");
                }
                else if (input == 3)
                {
                    var lista = evidenceManager.ListEvidence();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {lista[i]}");
                    }
                    Console.Write("Melyiket töröljük? (sorszám): ");
                    int torol = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (torol >= 0 && torol < lista.Count)
                    {
                        evidenceManager.RemoveEvidence(lista[torol]);
                        Console.WriteLine("Törölve.");
                    }
                }
                else if (input == 4)
                {
                    fut = false;
                }
            }
        }

        static void idovonalMegtekintese()
        {
            Console.Clear();
            Console.Write("Melyik ügy idővonalát nézzük meg? (Ügy ID): ");
            int id = Convert.ToInt32(Console.ReadLine());

            var ugy = caseManager.Ugyek.Find(x => x.Azonosito == id);
            if (ugy != null)
            {
                Console.WriteLine($"\n--- {ugy.Cim} idővonala ---");
                foreach (var esemeny in ugy.Idovonal)
                {
                    Console.WriteLine(esemeny);
                }
            }
            else
            {
                Console.WriteLine("Nincs ilyen ügy.");
            }
            Console.ReadLine();
        }

        static void elemzes()
        {
            Console.Clear();
            Console.WriteLine("--- Elemzés és Döntéshozatal ---");
            Person p = new Person("gyula gyula", 30, "Ismert elkövető");
            Suspect s = new Suspect(p, 40, "megfigyelt");
            Evidence e = new Evidence(1, "digitális", "log", 5);

            decisionEngine.Evaluation(s, e);
            Console.WriteLine("\n[ENTER]");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            bool program = true;
            while (program)
            {
                Console.Clear();
                Console.WriteLine("=== DIGITÁLIS NYOMOZÁS RENDSZER ===");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]}");
                }

                Console.Write("\nVálasztás: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 6)
                {
                    program = false;
                }
                else if (input >= 1 && input < 6)
                {
                    if (input == 1) ugykezeles();
                    else if (input == 2) szemelyhozzaad();
                    else if (input == 3) bizonyitek();
                    else if (input == 4) idovonalMegtekintese();
                    else if (input == 5) elemzes();
                }
                else
                {
                    Console.WriteLine("Rossz input! [ENTER]");
                    Console.ReadLine();
                }
            }
        }
    }
}
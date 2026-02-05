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

				if (input <1 || input > 3)
                {
                    Console.WriteLine("rossz input");
                }
                else
                {
                    if (input == 1) 
                    {
                        CaseManager.
                    }
                    else if (input == 2)
                    {
                        Console.Clear();
                        Console.Write("")
                    }

			}
            
		}
        static void Main(string[] args)
        {
            
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
                    if(input > 6 || input <1)
                    {
                        Console.WriteLine("rossz input!");
                    }
                    if (input == 1)
                    {
                        ugykezeles();
                    }
                    else if(input == 2)
                    {

                    }else if (input == 3)
                    {

                    }
                    else if (input == 4)
                    {

                    }else if (input == 5)
                    {

                    }
                }
			}
            

        }
    }
}

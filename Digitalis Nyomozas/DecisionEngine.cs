using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class DecisionEngine
	{
		public void Evaluation(Suspect gyanusitott, Evidence bizonyitek)
		{
			int vmi = bizonyitek.MegbizhatosagiErtek * 10;
			vmi += gyanusitott.GyanusitottSzint;
			if (vmi >= 80)
			{
				Console.WriteLine("gyanusitott elérte a kritikus pontot, keresztrefeszítest érdemel!");
			}
			else
			{
				Console.WriteLine("több információra van szükség gyanusított elítéléséhez");
			}
			
		}
	}
}

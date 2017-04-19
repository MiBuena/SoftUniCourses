using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringottsDb
{
    class Program
    {
        static void Main(string[] args)
        {
            GringottsContext context = new GringottsContext();
            List<string> firstLetters =
                context.WizzardDeposits.Where(x => x.DepositGroup == "Troll Chest")
                    .Select(x => x.FirstName.Substring(0, 1)).Distinct().OrderBy(x=>x)
                    .ToList();

            foreach (var element in firstLetters)
            {
                Console.WriteLine(element);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GringottsDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            GringottsContext context = new GringottsContext();

            //Tasks 1 and 2 Deposits Sum for Ollivander Family

            var depositGroups =
                context.WizzardDeposits.Where(x => x.MagicWandCreator == "Ollivander family")
                    .GroupBy(y => new {y.DepositGroup})
                    .Select(g => new {DepositGroup = g.Key.DepositGroup, Sum = g.Sum(x => x.DepositAmount)}).Where(arg => arg.Sum.Value < 150000)
               .OrderByDescending(arg => arg.Sum);

            foreach (var element in depositGroups)
            {
                Console.WriteLine($"{element.DepositGroup} - {element.Sum}");
            }


        }
    }
}

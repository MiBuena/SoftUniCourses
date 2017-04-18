using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int numberOfWeekendsHometown = int.Parse(Console.ReadLine());

            double normalWeekends = 48 - numberOfWeekendsHometown;

            double playDuringNormalWeekends = 0.75 * normalWeekends;

            double playDuringHolidays = 0.666666666666666667D * numberOfHolidays;

            double totalPlaying = playDuringHolidays + playDuringNormalWeekends + numberOfWeekendsHometown;

            if (year == "leap")
            {
                totalPlaying = totalPlaying * 1.15;
            }

            Console.WriteLine(Math.Floor(totalPlaying));

        }
    }
}

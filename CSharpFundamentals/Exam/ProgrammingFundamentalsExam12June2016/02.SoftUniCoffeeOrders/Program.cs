using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",
                                  CultureInfo.InvariantCulture);

                int capsulesCount = int.Parse(Console.ReadLine());

                int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);

                decimal a = pricePerCapsule*daysInMonth*capsulesCount;

                Console.WriteLine($"The price for the coffee is: ${a:F2}");

                total += a;
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
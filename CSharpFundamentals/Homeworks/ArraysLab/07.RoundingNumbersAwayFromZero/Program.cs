using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal[] inputNumbers =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToArray();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine("{0} => {1}", inputNumbers[i], Math.Round(inputNumbers[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}

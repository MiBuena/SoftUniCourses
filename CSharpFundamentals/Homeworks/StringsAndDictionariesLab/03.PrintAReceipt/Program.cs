using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.PrintAReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<decimal> inputNumbers =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToList();

            string firstLine = new string('-', 22);
            Console.Write("/");
            Console.Write(firstLine);
            Console.WriteLine("\\");

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                Console.WriteLine("| {0,20:f2} |", inputNumbers[i]);
            }

            Console.Write("|");
            Console.Write(firstLine);
            Console.WriteLine("|");

            Console.WriteLine("| Total: {0,13:f2} |", inputNumbers.Sum());

            Console.Write("\\");
            Console.Write(firstLine);
            Console.Write("/");



        }
    }
}

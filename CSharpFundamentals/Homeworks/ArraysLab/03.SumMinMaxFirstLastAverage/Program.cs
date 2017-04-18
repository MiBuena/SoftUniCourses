using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.SumMinMaxFirstLastAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            long[] intArray = new long[n];

            for (int i = 0; i < n; i++)
            {
                intArray[i] = long.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {intArray.Sum()}");
            Console.WriteLine($"Min = {intArray.Min()}");
            Console.WriteLine($"Max = {intArray.Max()}");
            Console.WriteLine($"First = {intArray.First()}");
            Console.WriteLine($"Last = {intArray.Last()}");
            Console.WriteLine($"Average = {intArray.Average()}");




        }
    }
}

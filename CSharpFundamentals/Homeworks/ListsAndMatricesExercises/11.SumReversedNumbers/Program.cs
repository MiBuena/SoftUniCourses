using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = inputNumbers.Length-1; i >= 0; i--)
            {
                sb.Append(inputNumbers[i]);
            }

            string reversed = sb.ToString();

            List<long> a = reversed.Split(' ').Select(long.Parse).ToList();

            long sum = a.Sum();

            Console.WriteLine(sum);
        }
    }
}

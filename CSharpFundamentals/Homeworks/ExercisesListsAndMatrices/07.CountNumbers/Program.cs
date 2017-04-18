using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            inputNumbers.Sort();

            int counter = 1;

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (i == inputNumbers.Count - 1 || inputNumbers[i+1]!= inputNumbers[i])
                {
                    Console.WriteLine($"{inputNumbers[i]} -> {counter}");
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }
        }
    }
}

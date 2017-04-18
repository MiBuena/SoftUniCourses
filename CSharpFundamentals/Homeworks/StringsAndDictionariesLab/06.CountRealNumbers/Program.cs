using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<decimal> inputNumbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            SortedDictionary<decimal, int> dictionary = new SortedDictionary<decimal, int>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (dictionary.ContainsKey(inputNumbers[i]))
                {
                    dictionary[inputNumbers[i]]++;
                }
                else
                {
                    dictionary.Add(inputNumbers[i], 1);
                }
            }

            foreach (var element in dictionary)
            {
                Console.WriteLine("{0} -> {1}", element.Key, element.Value);
            }
        }
    }
}

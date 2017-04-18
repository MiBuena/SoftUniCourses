using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Dictionary<int, int> frequenciesDictionary = new Dictionary<int, int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int counter = 1;

                if (!frequenciesDictionary.ContainsKey(inputNumbers[i]))
                {
                    frequenciesDictionary.Add(inputNumbers[i], counter);

                    for (int j = i + 1; j < inputNumbers.Length; j++)
                    {
                        if (inputNumbers[i] == inputNumbers[j])
                        {
                            frequenciesDictionary[inputNumbers[i]]++;
                        }
                    }
                }
            }

            var orderedDictionary = frequenciesDictionary.OrderByDescending(x => x.Value);


                Console.WriteLine(orderedDictionary.First().Key);

            
        }
    }
}

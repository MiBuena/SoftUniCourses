using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int longestSequence = 0;

            int longestSeqIndex = 0;

            int counter = 1;

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (i == inputNumbers.Count - 1 || inputNumbers[i + 1] != inputNumbers[i])
                {
                    if (counter > longestSequence)
                    {
                        longestSequence = counter;
                        longestSeqIndex = i;
                    }

                    counter = 1;

                }
                else
                {
                    counter++;
                }
            }

            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write($"{inputNumbers[longestSeqIndex]} ");
            }
        }
    }
}


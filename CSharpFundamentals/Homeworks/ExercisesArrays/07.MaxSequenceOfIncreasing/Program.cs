using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int longestIncreasingCounter = 1;

            int longestStartIndex = 0;

            int counter = 1;

            for (int i = 1; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] > inputNumbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > longestIncreasingCounter)
                    {
                        longestIncreasingCounter = counter;

                        longestStartIndex = i - counter;
                    }

                    counter = 1;
                }
            }

            if (counter > longestIncreasingCounter)
            {
                longestIncreasingCounter = counter;

                longestStartIndex = inputNumbers.Length - counter;
            }

            for (int i = longestStartIndex; i < longestIncreasingCounter + longestStartIndex; i++)
            {
                Console.Write("" + inputNumbers[i] + " ");
            }
        }
    }
}

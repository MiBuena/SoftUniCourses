using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int longestSequenceElement = inputArray[0];

            int longestSeqNumber = 1;

            int counter = 1;

            for (int i = 0; i < inputArray.Length-1; i++)
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    counter++;

                    if (longestSeqNumber < counter)
                    {
                        longestSeqNumber = counter;
                        longestSequenceElement = inputArray[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = 0; i < longestSeqNumber; i++)
            {
                Console.Write("" + longestSequenceElement + " ");
            }
        }
    }
}

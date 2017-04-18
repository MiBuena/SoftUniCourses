using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int difference = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int searchedNumber = inputArray[i] + difference;

                if (inputArray.Contains(searchedNumber))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }
    }
}

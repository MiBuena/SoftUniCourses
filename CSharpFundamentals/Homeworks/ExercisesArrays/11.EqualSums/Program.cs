using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool found = false;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int[] firstArray = inputNumbers.Take(i).ToArray();

                int[] secondArray = inputNumbers.Skip(i + 1).ToArray();



                if (firstArray.Sum() == secondArray.Sum())
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}

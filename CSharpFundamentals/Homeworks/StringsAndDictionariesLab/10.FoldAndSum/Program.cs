using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputNumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            int number = inputNumbers.Length/4;

            long[] leftNumbers = inputNumbers.Take(number).Reverse().ToArray();
            
        

            long[] rightNumbers = inputNumbers.Skip(3*number).Reverse().ToArray();

            

            long[] middle = inputNumbers.Skip(number).Take(2*number).ToArray();

            for (int i = 0; i < number; i++)
            {
                middle[i] += leftNumbers[i];

                middle[middle.Length - 1 - i] += rightNumbers[rightNumbers.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", middle));
        }
    }
}

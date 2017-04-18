using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> inputNumbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < inputNumbers.Count-1; i++)
            {
                if (inputNumbers[i] == inputNumbers[i+1])
                {
                    inputNumbers[i] *= 2;

                    inputNumbers.RemoveAt(i+1);

                    i-=2;

                    if (i < -1)
                    {
                        i = -1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}

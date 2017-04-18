using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                int sqrt = (int) Math.Sqrt(inputNumbers[i]);

                if (sqrt*sqrt == inputNumbers[i])
                {
                    result.Add(inputNumbers[i]);
                }
            }

            result.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

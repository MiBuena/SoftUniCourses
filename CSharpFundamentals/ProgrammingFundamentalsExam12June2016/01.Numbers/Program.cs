using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] inputArray =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToArray();

            decimal averageValue = (decimal)inputArray.Average();

            decimal[] numbers = inputArray.Where(x => x > averageValue).OrderByDescending(x=>x).Take(5).ToArray();

            if (numbers.Length > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

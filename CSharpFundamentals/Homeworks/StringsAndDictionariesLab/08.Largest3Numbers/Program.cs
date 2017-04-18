using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> inputNumbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();


            List<decimal> largestThreeNumbers = inputNumbers.OrderByDescending(x=>x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", largestThreeNumbers));
        }
    }
}

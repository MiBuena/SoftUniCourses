using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] firstArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long[] secondArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();


            int maxLength = Math.Max(firstArray.Length, secondArray.Length);

            long[] result = new long[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                result[i] = firstArray[i%firstArray.Length] + secondArray[i%secondArray.Length];


            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}

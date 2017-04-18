using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (inputArray.Length == 1)
            {
                Console.WriteLine(inputArray[0]);
            }
            else if (inputArray.Length%2 == 0)
            {
                int startIndex = inputArray.Length/2-1;

                Console.WriteLine($"{{ { inputArray[startIndex]}, { inputArray[startIndex + 1]} }}");
            }
            else
            {
                int startIndex = inputArray.Length / 2 - 1;

                Console.WriteLine($"{{ { inputArray[startIndex]}, { inputArray[startIndex + 1]}, { inputArray[startIndex + 2]} }}");

            }
        }
    }
}

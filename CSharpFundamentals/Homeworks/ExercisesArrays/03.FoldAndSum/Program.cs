using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            int arraysLength = inputArray.Length/4;

            long[] leftArray = inputArray.Take(arraysLength).ToArray();

            long[] rightArray = inputArray.Skip(3*arraysLength).ToArray();

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            long[] firstArray = leftArray.Concat(rightArray).ToArray();

            long[] secondArray = inputArray.Skip(arraysLength).Take(2*arraysLength).ToArray();

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] += secondArray[i];
            }


            Console.WriteLine(string.Join(" ", firstArray));
        }
    }
}

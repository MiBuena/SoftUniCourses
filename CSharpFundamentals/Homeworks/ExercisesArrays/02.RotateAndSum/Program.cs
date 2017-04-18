using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            long[] result = new long[inputArray.Length];



            for (int i = 0; i < rotations; i++)
            {
                long[] rotationArray = new long[inputArray.Length];

                rotationArray[0] = inputArray[inputArray.Length - 1];

                for (int j = 1; j < rotationArray.Length; j++)
                {
                    rotationArray[j] = inputArray[j - 1];
                }

                for (int j = 0; j < result.Length; j++)
                {
                    result[j] += rotationArray[j];
                }

                inputArray = rotationArray;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

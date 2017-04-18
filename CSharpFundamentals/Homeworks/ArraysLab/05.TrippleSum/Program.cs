using System;
using System.Linq;

namespace _05.TrippleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputArray =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

            bool found = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    long sum = inputArray[i] + inputArray[j];

                    if (inputArray.Contains(sum))
                    {
                        found = true;
                        Console.WriteLine($"{inputArray[i]} + {inputArray[j]} == {sum}");
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}

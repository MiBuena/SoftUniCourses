using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputArray = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<long> tryingArray = new List<long>();


            bool found = false;

            BigInteger difference = long.MaxValue;


            BigInteger sumGreat = long.MinValue;

;

            long minDifference = long.MaxValue;

            for (int i = 0; i < inputArray.Count; i++)
            {
                A(inputArray, tryingArray);
                tryingArray.RemoveAt(i);

                if (inputArray[i] == tryingArray.Sum())
                {
                    found = true;
                    sumGreat = inputArray[i];
                    break;
                }

                if (Math.Abs(inputArray[i] - tryingArray.Sum()) < minDifference)
                {
                    minDifference = Math.Abs(inputArray[i] - tryingArray.Sum());
                }

                tryingArray.Clear();

            }

            if (found)
            {
                Console.WriteLine("Yes, sum={0}", sumGreat);
            }
            else
            {
                Console.WriteLine("No, diff={0}", minDifference);
            }
        }

        private static void A(List<long> inputArray, List<long> tryingArray)
        {
            for (int i = 0; i < inputArray.Count; i++)
            {
                tryingArray.Add(inputArray[i]);
            }
        }
    }
}

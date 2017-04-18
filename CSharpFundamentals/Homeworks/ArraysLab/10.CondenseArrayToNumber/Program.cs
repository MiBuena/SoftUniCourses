using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arrayInts = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();


            while (true)
            {
                if (arrayInts.Length == 1)
                {
                    break;
                }

                long[] smallArray = new long[arrayInts.Length - 1];

                for (int i = 0; i < arrayInts.Length - 1; i++)
                {

                    smallArray[i] = arrayInts[i] + arrayInts[i + 1];

                }

                arrayInts = smallArray;

            }

            Console.WriteLine(arrayInts[0]);
        }
    }
}

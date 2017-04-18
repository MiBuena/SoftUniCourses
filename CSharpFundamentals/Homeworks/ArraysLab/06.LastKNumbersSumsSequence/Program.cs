using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] intArray = new long[n];

            intArray[0] = 1;

            for (int i = 1; i < intArray.Length; i++)
            {
                int startIndex = i-k;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }


                for (int j = startIndex; j < i; j++)
                {
                    intArray[i] += intArray[j];
                }
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0} ", intArray[i]);
            }
        }
    }
}

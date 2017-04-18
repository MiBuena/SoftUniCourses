using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] intArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = intArray.Length-1; i >= 0; i--)
            {
                Console.Write("{0} ", intArray[i]);
            }
        }
    }
}

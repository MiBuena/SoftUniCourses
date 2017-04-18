using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < inputArray.Length/2; i++)
            {
                string exchangeString = inputArray[i];
                inputArray[i] = inputArray[inputArray.Length - i-1];
                inputArray[inputArray.Length - i-1] = exchangeString;
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}

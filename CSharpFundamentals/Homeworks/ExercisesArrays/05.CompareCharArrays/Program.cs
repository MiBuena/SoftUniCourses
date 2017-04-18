using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int minLength = Math.Min(firstArray.Length, secondArray.Length);

            bool foundDifference = false;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    foundDifference = true;
                    break;

                }
                else if(firstArray[i]>secondArray[i])
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));

                    foundDifference = true;
                    break;
                }
            }

            if (!foundDifference)
            {
                if (firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                }
                else
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                }
            }
        }

    }
}

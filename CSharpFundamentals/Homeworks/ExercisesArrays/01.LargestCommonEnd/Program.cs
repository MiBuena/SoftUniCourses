using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();

            string[] secondArray = Console.ReadLine().Split().ToArray();

            int leftLength = 0;

            int rightLength = 0;

            int minLengthArray = Math.Min(firstArray.Length, secondArray.Length);


            for (int i = 0; i < minLengthArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftLength++;
                }
                else
                {
                    break;
                }
            }

            int firstIndex = firstArray.Length;
            int secondIndex = secondArray.Length;

            for (int i = minLengthArray-1; i >= 0; i--)
            {
                firstIndex--;
                secondIndex--;

                if (firstArray[firstIndex] == secondArray[secondIndex])
                {
                    rightLength++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(leftLength, rightLength));
        }
    }
}

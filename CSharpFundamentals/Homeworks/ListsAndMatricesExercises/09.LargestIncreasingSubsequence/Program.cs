using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _09.LargestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> len = new List<int>();

            List<int> previousPosition = new List<int>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                len.Add(0);
                previousPosition.Add(0);
            }



            for (int x = 0; x < inputNumbers.Count; x++)
            {
                len[x] = 1;

                previousPosition[x] = -1;

                for (int i = 0; i <= x - 1; i++)
                {
                    if (inputNumbers[i] < inputNumbers[x] && len[i] + 1 > len[x])
                    {
                        len[x] = 1 + len[i];
                        previousPosition[x] = i;
                    }
                }
            }

            int maxLength = len.Max();

            int numberIndex = len.IndexOf(maxLength);

            List<int> a = new List<int>();

            while (true)
            {

                if (numberIndex == -1)
                {
                    break;
                }

                int number = inputNumbers[numberIndex];

                a.Add(number);

                numberIndex = previousPosition[numberIndex];
            }

            a.Reverse();

            Console.WriteLine(string.Join(" ", a));
        }

    }
}
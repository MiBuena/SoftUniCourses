using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputNumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> bombNumberParameters = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long bombNumber = bombNumberParameters[0];

            long bombPower = bombNumberParameters[1];

            while (true)
            {
                int index = inputNumbers.IndexOf(bombNumber);

                if (index == -1)
                {
                    break;
                }

                for (int i = 0; i <= bombPower; i++)
                {
                    if (index - i >= 0)
                    {
                        inputNumbers[index - i] = 0;
                    }

                    if (index + i < inputNumbers.Count)
                    {
                        inputNumbers[index + i] = 0;
                    }
                }
            }

            Console.WriteLine(inputNumbers.Sum());

        }
    }
}

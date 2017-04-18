using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[n+1];

            bool [] boolArray = new bool[n + 1];

            for (int i = 0; i < boolArray.Length; i++)
            {
                boolArray[i] = true;
            }

            for (int i = 0; i < n; i++)
            {
                numbersArray[i] = i;
            }

            int firstNumber = 1;


            while (true)
            {
                bool found = false;

                for (int i = firstNumber + 1; i < boolArray.Length; i++)
                {
                    if (boolArray[i])
                    {
                        firstNumber = i;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    break;
                }

                int level = 2;

                while (true)
                {
                    int nextIndex = level*firstNumber;

                    level++;

                    if (nextIndex > boolArray.Length - 1)
                    {
                        break;
                    }

                    boolArray[nextIndex] = false;
                }
            }

            for (int i = 2; i < boolArray.Length; i++)
            {
                if (boolArray[i])
                {
                    Console.Write("" + i + " ");
                }
            }
        }
    }
}

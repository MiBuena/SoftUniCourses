using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            for (int i = 0; i < 2* number; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (i%2 == 0)
                {
                    oddNumbersSum += numbers;
                }
                else
                {
                    evenNumbersSum += numbers;
                }
            }

            if (evenNumbersSum == oddNumbersSum)
            {
                Console.WriteLine("Yes, sum={0}", oddNumbersSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(evenNumbersSum-oddNumbersSum));
            }
        }
    }
}

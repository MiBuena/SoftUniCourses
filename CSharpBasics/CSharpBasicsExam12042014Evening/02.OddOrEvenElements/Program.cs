using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.OddOrEvenElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            string input = Console.ReadLine();

            decimal oddSum = 0;
            decimal oddMin = 0;
            decimal oddMax = 0;
            decimal evenSum = 0;
            decimal evenMin = 0;
            decimal evenMax = 0;

            if (input == "")
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else
            {
                decimal[] numbers = input.Split(' ').Select(decimal.Parse).ToArray();

                if (numbers.Length == 1)
                {
                    decimal[] oddNumbers = numbers.Where((value, index) => index % 2 == 0).ToArray();

                    oddSum = oddNumbers.Sum();
                    oddMin = oddNumbers.Min();
                    oddMax = oddNumbers.Max();

                    Console.WriteLine("OddSum={0:G29}, OddMin={1:G29}, OddMax={2:G29}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
                }
                else
                {
                    decimal [] oddNumbers = numbers.Where((value, index) => index % 2 == 0).ToArray();

                    oddSum = oddNumbers.Sum();
                    oddMin = oddNumbers.Min();
                    oddMax = oddNumbers.Max();

                    decimal[] evenNumbers = numbers.Where((value, index) => index % 2 != 0).ToArray();

                    evenSum = evenNumbers.Sum();
                    evenMin = evenNumbers.Min();
                    evenMax = evenNumbers.Max();

                    Console.WriteLine("OddSum={0:G29}, OddMin={1:G29}, OddMax={2:G29}, EvenSum={3:G29}, EvenMin={4:G29}, EvenMax={5:G29}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
                }
            }

        }
    }
}

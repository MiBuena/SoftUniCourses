using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Number primeChecker = new Number(inputNumber);

            bool result = primeChecker.CheckIfPrime(inputNumber);

            if (result)
            {
                primeChecker.PrimeNumberOrNot = true;
            }
            else
            {
                primeChecker.PrimeNumberOrNot = false;
            }

            primeChecker.FindNextPrimeNumber();

            Console.WriteLine(primeChecker);
        }
    }

    class Number
    {
        public Number(int number)
        {
            this.IntegerNumber = number;
        }

        public int IntegerNumber { get; set; }
        public bool PrimeNumberOrNot { get; set; }
        public int NextPrimeNumber { get; set; }

        public bool CheckIfPrime(int primeCandidate)
        {
            for (int i = 2; i <= Math.Sqrt(primeCandidate); i++)
            {
                if (primeCandidate % i == 0)
                {
                    return false;
                }

            }

            return true;
        }

        public void FindNextPrimeNumber()
        {
            int numberToCheck = this.IntegerNumber;

            while (true)
            {
                if (this.CheckIfPrime(++numberToCheck))
                {
                    this.NextPrimeNumber = numberToCheck;
                    break;
                }
            }
        }

        public override string ToString()
        {
            string number = $"{this.NextPrimeNumber}, {this.PrimeNumberOrNot.ToString().ToLower()}";
            return number;
        }
    }
}

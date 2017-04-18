using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPosition = int.Parse(Console.ReadLine());

            int endPosition = int.Parse(Console.ReadLine());

            Fibonacci fibonacci = new Fibonacci();

            fibonacci.FillFibonacciRange(endPosition);

            Console.WriteLine(string.Join(", ", fibonacci.GetNumbersInRange(startPosition, endPosition)));
        }
    }

    public class Fibonacci
    {

        public Fibonacci()
        {
            this.FibonacciNumbers = new List<long>();
        }

        public List<long> FibonacciNumbers { get; set; }


        public void FillFibonacciRange(long endPosition)
        {
            
            FibonacciNumbers.Add(0);
            FibonacciNumbers.Add(1);

            int index = 0;

            while (true)
            {
                if (index == endPosition)
                {
                    break;
                }

                long newNumber = FibonacciNumbers[index] + FibonacciNumbers[index + 1];
                FibonacciNumbers.Add(newNumber);

                index++;
            }

        }


        public List<long> GetNumbersInRange(int startPosition, int endPosition)
        {

            List<long> FibonacciSequence = new List<long>();

            for (int i = startPosition; i < endPosition; i++)
            {
                FibonacciSequence.Add(FibonacciNumbers[i]);
            }

            return FibonacciSequence;
        }
    }
}

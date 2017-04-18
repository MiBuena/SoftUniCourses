using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputNumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            bool done = false;


            while (true)
            {
                if (done)
                {
                    break;
                }

                string[] command = Console.ReadLine().Split(' ').ToArray();

                switch (command[0])
                {
                    case "add":
                        AddNumber(inputNumbers, int.Parse(command[1]), long.Parse(command[2]));
                        break;
                    case "addMany":
                        List<long> numbersToAdd = command.Skip(2).Take(command.Length - 1).Select(long.Parse).ToList();
                        AddManyNumbers(inputNumbers, int.Parse(command[1]), numbersToAdd);
                        break;
                    case "contains":
                        long searchedNumber = long.Parse(command[1]);
                        Console.WriteLine(inputNumbers.IndexOf(searchedNumber));
                        break;
                    case "remove":
                        int removeIndex = int.Parse(command[1]);
                        inputNumbers.RemoveAt(removeIndex);
                        break;
                    case "shift":
                        ShiftToTheLeft(inputNumbers, int.Parse(command[1]));
                        break;
                    case "sumPairs":
                        inputNumbers = SumNumbers(inputNumbers);
                        break;
                    default:
                        PrintNumbers(inputNumbers);
                        done = true;
                        break;
                }
            }
        }

        private static void PrintNumbers(List<long> inputNumbers)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", inputNumbers));
            Console.Write("]");
        }

        private static List<long> SumNumbers(List<long> inputNumbers)
        {
            List<long> sum = new List<long>();

            bool added = false;

            for (int i = 1; i < inputNumbers.Count; i += 2)
            {
                sum.Add(inputNumbers[i] + inputNumbers[i - 1]);
                added = true;
            }

            if (inputNumbers.Count%2 == 1)
            {
                sum.Add(inputNumbers[inputNumbers.Count-1]);
            }

            if (added)
            {
                return sum;
            }

            return inputNumbers;
        }

        private static void ShiftToTheLeft(List<long> inputNumbers, int positions)
        {
            for (int i = 0; i < positions; i++)
            {
                inputNumbers.Add(inputNumbers[0]);
                inputNumbers.RemoveAt(0);
            }
        }

        private static void AddManyNumbers(List<long> inputNumbers, int index, List<long> numbersToAdd)
        {
            inputNumbers.InsertRange(index, numbersToAdd);

        }

        private static void AddNumber(List<long> inputNumbers, int index, long numberToAdd)
        {
            inputNumbers.Insert(index, numberToAdd);
        }
    }
}

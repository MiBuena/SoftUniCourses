using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stackCollection = new Stack<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] inputData = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (inputData[0])
                    {
                        case "Push":
                            Push(inputData.Skip(1).ToArray(), stackCollection);
                            break;
                        case "Pop":
                            Pop(stackCollection);
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stackCollection)
                {
                    Console.WriteLine(element);
                }
            }

        }

        private static void Pop(Stack<string> stackCollection)
        {
            stackCollection.Pop();
        }

        private static void Push(string[] inputData, Stack<string> stackCollection)
        {
            foreach (var element in inputData)
            {
                stackCollection.Push(element);
            }
        }
    }
}

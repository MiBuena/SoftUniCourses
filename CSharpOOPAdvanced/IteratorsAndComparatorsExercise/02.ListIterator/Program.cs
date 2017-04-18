using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ListIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandExecutor commandExecutor = new CommandExecutor();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] commandParameters = input.Split(' ');

                try
                {
                    Console.Write(commandExecutor.ExecuteCommand(commandParameters));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}

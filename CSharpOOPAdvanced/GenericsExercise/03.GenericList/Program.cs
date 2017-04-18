using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandInterpreter interpreter = new CommandInterpreter();

            CustomList<string> customList = new CustomList<string>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] inputParameters = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);


                    Console.Write(interpreter.ExecuteCommand(inputParameters, customList));
                
            }



        }
    }
}

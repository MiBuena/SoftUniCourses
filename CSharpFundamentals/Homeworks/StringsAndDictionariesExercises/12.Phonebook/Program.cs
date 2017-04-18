using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,string> phoneBook = new Dictionary<string, string>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                List<string> inputParameters = input.Split(' ').ToList();

                if (inputParameters[0] == "A")
                {
                    if (phoneBook.ContainsKey(inputParameters[1]))
                    {
                        phoneBook[inputParameters[1]] = inputParameters[2];
                    }
                    else
                    {
                        phoneBook.Add(inputParameters[1], inputParameters[2]);
                    }
                }
                else
                {
                    if (phoneBook.Count==0 || !phoneBook.ContainsKey(inputParameters[1]))
                    {
                        Console.WriteLine($"Contact {inputParameters[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{inputParameters[1]} -> {phoneBook[inputParameters[1]]}");
                    }
                }
            }
        }
    }
}

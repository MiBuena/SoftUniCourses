using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(new char[] { ',' , ';', '\'', ':', '.', '!', '(',')', '\"', '\\', '/', '[', ']', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();

            List<string> upperCase = new List<string>();

            List<string> mixedCase = new List<string>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if(inputList[i].All(x=>(int)x>=65 && (int)x<=90) || inputList[i].All(x => (int)x >= 97 && (int)x <= 122))
                {
                    if (inputList[i].ToUpper() == inputList[i])
                    {
                        upperCase.Add(inputList[i]);
                    }
                    else if (inputList[i].ToLower() == inputList[i])
                    {
                        lowerCase.Add(inputList[i]);
                    }
                    else
                    {
                        mixedCase.Add(inputList[i]);
                    }
                }
            else
                {
                    mixedCase.Add(inputList[i]);
                }

               

            }

            Console.WriteLine("Lower-case: " + string.Join(" ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(" ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(" ", upperCase));

        }
    }
}

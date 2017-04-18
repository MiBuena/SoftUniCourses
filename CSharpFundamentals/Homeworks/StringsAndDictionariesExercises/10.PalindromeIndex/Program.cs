using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PalindromeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversedWord = string.Join("", input.ToCharArray().Reverse());

            if (reversedWord == input)
            {
                Console.WriteLine("-1");
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string leftSubstring = input.Substring(0, i);
                    string rightSubstring = input.Substring(i+1);

                    string newString = leftSubstring + rightSubstring;

                    string reversedWord2 = string.Join("", newString.ToCharArray().Reverse());

                    if (reversedWord2 == newString)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}

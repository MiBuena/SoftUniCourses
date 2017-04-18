using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CommonStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();

            string secondString = Console.ReadLine();

            bool exists = false;

            if (firstString.Length >= secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    string substringA = firstString.Substring(i);

                    string substringB = firstString.Substring(0, firstString.Length - i);

                    if (secondString.Contains(substringA) || secondString.Contains(substringB))
                    {
                        exists = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    string substringA = secondString.Substring(i);

                    string substringB = secondString.Substring(0, secondString.Length - i);

                    if (firstString.Contains(substringA) || firstString.Contains(substringB))
                    {
                        exists = true;
                    }
                }
            }

            if (exists)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}

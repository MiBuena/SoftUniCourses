using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FitString20Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            if (inputString.Length >= 20)
            {
                Console.WriteLine(inputString.Substring(0, 20));
            }
            else
            {
                Console.WriteLine(inputString.PadRight(20, '*'));
            }
        }
    }
}

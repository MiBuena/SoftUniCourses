using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintStringLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"str[{i}] -> '{str[i]}'");
            }
        }
    }
}

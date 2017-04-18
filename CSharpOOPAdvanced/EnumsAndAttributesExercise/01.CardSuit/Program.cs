using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CardSuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(input + ":");

            var enumValues = Enum.GetValues(typeof (CardSuit));

            foreach (var element in enumValues)
            {
                Console.WriteLine($"Ordinal value: {(int)element}; Name value: {element}");
            }
        }
    }
}


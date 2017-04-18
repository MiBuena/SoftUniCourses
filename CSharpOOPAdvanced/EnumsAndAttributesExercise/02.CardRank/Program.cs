using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CardsProject;

namespace _02.CardRank
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Console.WriteLine(input + ":");

            var enumValues = Enum.GetValues(typeof(CardsProject.CardRank));

            foreach (var element in enumValues)
            {
                Console.WriteLine($"Ordinal value: {(int)element}; Name value: {element}");
            }
        }
    }
}

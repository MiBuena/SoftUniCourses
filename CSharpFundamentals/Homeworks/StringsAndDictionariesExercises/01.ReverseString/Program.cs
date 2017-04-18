using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] wordArray = word.ToCharArray();

            Array.Reverse(wordArray);

            string reversedWord = new string(wordArray);

            Console.WriteLine(reversedWord);
        }
    }
}

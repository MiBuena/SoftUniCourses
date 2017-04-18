using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] alphabetArray = new char[26];

            int index = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabetArray[index] = i;
                index++;
            }

            string word = Console.ReadLine();

            string alphabet = string.Join("", alphabetArray);

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {alphabet.IndexOf(word[i])}");
            }
        }
    }
}

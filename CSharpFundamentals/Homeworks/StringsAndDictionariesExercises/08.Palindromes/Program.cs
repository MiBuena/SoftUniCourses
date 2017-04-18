using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputWords =
                Console.ReadLine()
                    .Split(new char[] {' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            SortedSet<string> uniquePalindromes = new SortedSet<string>();

            for (int i = 0; i < inputWords.Count; i++)
            {
                string reversedWord = string.Join("", inputWords[i].ToCharArray().Reverse());

                if (inputWords[i] == reversedWord)
                {
                    uniquePalindromes.Add(inputWords[i]);
                }
            }


            Console.WriteLine(string.Join(", ", uniquePalindromes));
        }
    }
}

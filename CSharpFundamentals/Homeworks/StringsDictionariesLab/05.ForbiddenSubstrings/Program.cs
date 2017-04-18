using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForbiddenSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] forbiddenWords = Console.ReadLine().Split(' ').ToArray();


            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                string replacementString = new string('*', forbiddenWords[i].Length);

                text = text.Replace(forbiddenWords[i], replacementString);
            }


            Console.WriteLine(text);
        }
    }
}

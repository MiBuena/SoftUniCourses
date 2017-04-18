using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.ExtractSentencesKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string text2 = Console.ReadLine();

            string[] sentenceCollection = text2.Split(new char[] {'.', '!', '?'});


            for (int i = 0; i < sentenceCollection.Length; i++)
            {
                string text = sentenceCollection[i];
                string pattern = @"\w+";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(text);

                foreach (Match element in matches)
                {
                    if (element.ToString() == word)
                    {
                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}

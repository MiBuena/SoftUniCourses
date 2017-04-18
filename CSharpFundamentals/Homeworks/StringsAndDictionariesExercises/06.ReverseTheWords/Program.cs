using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ReverseTheWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([. , : ; = ( ) & \[ \] "" ' \ \/ ! ?]+|[^. , : ; = ( ) & \[ \] "" ' \ \/ ! ?]+)";
            string wordBorders = ". , : ; = ( ) & [ ] \" ' \\ / ! ? ";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            List<string> allSymbols = new List<string>();

            foreach (Match element in matches)
            {
                allSymbols.Add(element.ToString());
            }

            List<string> allWords = new List<string>();

            for (int i = 0; i < allSymbols.Count; i++)
            {
                if (!wordBorders.Contains(allSymbols[i][0]))
                {
                    allWords.Add(allSymbols[i]);
                    allSymbols[i] = null;
                }
            }

            allWords.Reverse();

            int index = 0;

            for (int i = 0; i < allSymbols.Count; i++)
            {
                if (allSymbols[i] == null)
                {
                    allSymbols[i] = allWords[index];
                    index++;
                }
            }

            Console.WriteLine(string.Join("", allSymbols));
        }
    }
}

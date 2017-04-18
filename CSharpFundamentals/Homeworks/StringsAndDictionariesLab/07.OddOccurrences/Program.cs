using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(' ').ToArray();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();


            for (int i = 0; i < inputWords.Length; i++)
            {
                if (dictionary.ContainsKey(inputWords[i].ToLower()))
                {
                    dictionary[inputWords[i].ToLower()]++;
                }
                else
                {
                    dictionary.Add(inputWords[i].ToLower(), 1);
                }
            }

            HashSet<string> words = new HashSet<string>();

            foreach (var element in dictionary)
            {
                if (element.Value%2 == 1)
                {
                    words.Add(element.Key.ToLower());
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}

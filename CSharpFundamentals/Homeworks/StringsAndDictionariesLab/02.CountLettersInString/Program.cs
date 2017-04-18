using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (dictionary.ContainsKey(str[i]))
                {
                    dictionary[str[i]]++;
                }
                else
                {
                    dictionary.Add(str[i], 1);
                }
            }

            var a = dictionary.OrderBy(x => x.Key);

            foreach (var element in a)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }


        }
    }
}

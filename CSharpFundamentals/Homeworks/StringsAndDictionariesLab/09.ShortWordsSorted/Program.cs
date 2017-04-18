using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            List<string> words = text.Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '},
                        StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            List<string> a = words.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();

            Console.WriteLine(string.Join(", ", a));
        }
    }
}

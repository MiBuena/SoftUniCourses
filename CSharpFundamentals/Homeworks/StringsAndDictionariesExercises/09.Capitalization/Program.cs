using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputWords =
    Console.ReadLine()
        .Split(new char[] { ' ', ',', '.', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries)
        .ToList();

            for (int i = 0; i < inputWords.Count; i++)
            {
                inputWords[i] = char.ToUpper(inputWords[i][0]) + inputWords[i].Substring(1);
            }

            Console.WriteLine(string.Join(" ", inputWords));
        }
    }
}

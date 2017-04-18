using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Lake<string> lake = new Lake<string>(inputNumbers);

            string result = "";

            foreach (var element in lake)
            {
                result += string.Format($"{element}, ");
            }

            
            Console.WriteLine(result.Substring(0, result.Length-2));
        }
    }
}

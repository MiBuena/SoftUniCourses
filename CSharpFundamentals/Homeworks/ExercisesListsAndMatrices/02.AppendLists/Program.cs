using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);

            var result = new List<string>();

            for (int i = inputList.Length-1; i >= 0; i--)
            {
                var list = inputList[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < list.Length; j++)
                {
                        result.Add(list[j]);
                    
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

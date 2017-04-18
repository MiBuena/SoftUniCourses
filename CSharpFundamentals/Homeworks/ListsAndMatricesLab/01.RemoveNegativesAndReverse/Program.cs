using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] < 0)
                {
                    inputList.RemoveAt(i);
                    i--;
                }
            }

            inputList.Reverse();

            if (inputList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", inputList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}

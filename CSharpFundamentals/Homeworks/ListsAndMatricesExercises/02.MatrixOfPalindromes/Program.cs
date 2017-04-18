using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int rows = parameters[0];
            int cols = parameters[1];

            string[][] matrix = new string[rows][];

            char firstChar = 'a';
            char secondChar = 'a';

            for (int row = 0; row < rows; row++)
            {
                firstChar = (char) (97 + row);

                for (int col = 0; col < cols; col++)
                {
                    secondChar = (char)(firstChar + col);

                    Console.Write($"{firstChar}{secondChar}{firstChar} ");
                }

                Console.WriteLine();
            }
        }
    }
}

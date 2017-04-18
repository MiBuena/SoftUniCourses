using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int rows = parameters[0];
            int cols = parameters[1];

            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            }

            int counter = 0;

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    bool firstCondition = matrix[row][col] == matrix[row][col + 1];
                    bool secondCondition = matrix[row + 1][col] == matrix[row + 1][col + 1];
                    bool thirdCondition = matrix[row][col] == matrix[row + 1][col];

                    if (firstCondition&&secondCondition&&thirdCondition)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}

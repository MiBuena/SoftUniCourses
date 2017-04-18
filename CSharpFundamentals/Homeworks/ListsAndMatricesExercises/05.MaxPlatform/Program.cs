using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int rows = parameters[0];
            int cols = parameters[1];

            long[][] matrix = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            }

            long sum = 0;

            long maxSum = long.MinValue;

            int maxRow = 0;

            int maxCol = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    sum = FindSum(row, col, matrix);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine(maxSum);

            for (int i = maxRow; i < maxRow+3; i++)
            {
                for (int j = maxCol; j < maxCol+3; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }
        }

        private static long FindSum(int row, int col, long[][] matrix)
        {
            long sum = 0;

            for (int i = row; i < row+3; i++)
            {
                for (int j = col; j < col+3; j++)
                {
                    sum += matrix[i][j];
                }
            }

            return sum;
        }
    }
}

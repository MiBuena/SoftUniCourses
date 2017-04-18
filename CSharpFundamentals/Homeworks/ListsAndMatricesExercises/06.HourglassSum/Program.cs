using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.HourglassSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<long>> matrix = new List<List<long>>();

            for (int i = 0; i < 6; i++)
            {
                 matrix.Add(Console.ReadLine().Split(' ').Select(long.Parse).ToList());
            }

            long maxSum = long.MinValue;

            int maxPositionRow = 0;
            int maxPositionCol = 0;


            for (int row = 0; row < matrix.Count-2; row++)
            {
                for (int col = 0; col < matrix[row].Count-2; col++)
                {
                    long sum = Sum(matrix, row, col);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxPositionRow = row;
                        maxPositionCol = col;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }

        private static long Sum(List<List<long>> matrix, int row, int col)
        {
            long sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] + matrix[row+1][col + 1] + matrix[row+2][col] + matrix[row+ 2][col + 1] + matrix[row+ 2][col + 2];

            return sum;
        }
    }
}

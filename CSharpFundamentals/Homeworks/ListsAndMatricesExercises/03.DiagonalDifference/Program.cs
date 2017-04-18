using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int sum1 = 0;
            int sum2 = 0;

            int col = 0;

            for (int row = 0; row < n; row++)
            {
                sum1 += matrix[row][col];
                col++;
            }

            col = n - 1;

            for (int row = 0; row < n; row++)
            {
                sum2 += matrix[row][col];
                col--;
            }

            Console.WriteLine(Math.Abs(sum1-sum2));
        }
    }
}

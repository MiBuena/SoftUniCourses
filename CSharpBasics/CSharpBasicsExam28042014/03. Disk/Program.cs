using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Disk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int r = int.Parse(Console.ReadLine());

            int center = n/2;

            char[,] matrix = new char[n,n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    bool isInTheCircle = (col - center)*(col - center) + (row - center)*(row - center) <= r*r;

                    if (isInTheCircle)
                    {
                        matrix[row, col] = '*';
                    }
                    else
                    {
                        matrix[row, col] = '.';
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string [] [] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ');
            }

            for (int col = 0; col < cols; col++)
            {
                for (int row = rows-1; row >= 0; row--)
                {
                    Console.Write($"{matrix[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}

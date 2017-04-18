using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BuildAMatrixOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';

            int rows = int.Parse(Console.ReadLine());

            int cols = int.Parse(Console.ReadLine());

            char [] [] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];

                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = a++;
                }
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }

                Console.WriteLine();

            }



        }
    }
}

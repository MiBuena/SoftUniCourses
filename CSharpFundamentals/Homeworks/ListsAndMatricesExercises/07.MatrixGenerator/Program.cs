using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ').ToArray();

            string matrixType = inputNumbers[0];

            int rows = int.Parse(inputNumbers[1]);

            int cols = int.Parse(inputNumbers[2]);

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
            }


            switch (matrixType)
            {
                case "A":
                    FillMatrixA(rows, cols, matrix);
                    break;
                case "B":
                    FillMatrixB(rows, cols, matrix);
                    break;
                case "C":
                    FillMatrixC(rows, cols, matrix);
                    break;
                case "D":
                    FillMatrixD(rows, cols, matrix);
                    break;
            }

            PrintMatrix(matrix);
        }

        private static void FillMatrixD(int rows, int cols, int[][] matrix)
        {
            int number = 1;
            int numberWay = 1;
            int rowStartIndex = 0;
            int colStartIndex = 0;
            int rowEndIndex = rows - 1;
            int colEndIndex = cols - 1;
            int row = 0;
            int col = 0;


            while (true)
            {
                bool changedAValue = false;

                if (numberWay == 1)
                {
                    for (row = rowStartIndex; row < rows; row++)
                    {
                        if (matrix[row][col] != 0)
                        {
                            break;
                        }

                        changedAValue = true;

                        matrix[row][col] = number++;
                    }

                    row -= 1;
                    colStartIndex = col+1;
                }
                else if (numberWay == 2)
                {
                    for (col = colStartIndex; col < cols; col++)
                    {
                        if (matrix[row][col] != 0)
                        {
                            break;
                        }

                        changedAValue = true;

                        matrix[row][col] = number++;
                    }

                    rowStartIndex = row - 1;
                    col-=1;
                }
                else if (numberWay == 3)
                {
                    for (row = rowStartIndex; row >= 0; row--)
                    {
                        if (matrix[row][col] != 0)
                        {
                            break;
                        }

                        changedAValue = true;

                        matrix[row][col] = number++;
                    }

                    row += 1;
                    colStartIndex = col - 1;

                }
                else if (numberWay == 4)
                {
                    for (col = colStartIndex; col >= 0; col--)
                    {
                        if (matrix[row][col] != 0)
                        {
                            break;
                        }

                        changedAValue = true;

                        matrix[row][col] = number++;
                    }

                    rowStartIndex = row + 1;
                    col += 1;
                }
                else
                {
                    numberWay = numberWay%4 -1;
                    changedAValue = true;
                }


                if (!changedAValue)
                {
                    break;
                }

                numberWay++;



            }
        }

        private static void FillMatrixC(int rows, int cols, int[][] matrix)
        {
            int number = 1;

            for (int row = rows - 1; row >= 0; row--)
            {

                int col = 0;
                for (int row2 = row; row2 < rows; row2++)
                {
                    matrix[row2][col] = number++;
                    col++;
                }
            }


            for (int col = 1; col < cols; col++)
            {
                int row = 0;

                for (int col2 = col; col2 < cols; col2++)
                {
                    matrix[row][col2] = number++;
                    row++;
                }
            }
        }

        private static void FillMatrixA(int rows, int cols, int[][] matrix)
        {
            int number = 1;

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row][col] = number++;
                }

            }
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }

                Console.WriteLine();

            }
        }

        private static void FillMatrixB(int rows, int cols, int[][] matrix)
        {

            int number = 1;

            for (int col = 0; col < cols; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row][col] = number++;
                    }
                }
                else
                {
                    for (int row = rows - 1; row >= 0; row--)
                    {
                        matrix[row][col] = number++;
                    }
                }
            }
        }
    }
}

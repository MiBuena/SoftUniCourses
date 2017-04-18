using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitPaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matrix = new int[8,4];
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }

            int n = int.Parse(Console.ReadLine());

            for (int m = 0; m < n; m++)
            {
                string a = Console.ReadLine();

                string[] array = a.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);

                int[] arrayInt = new int[array.Length - 1];

                for (int i = 0; i < arrayInt.Length; i++)
                {
                    arrayInt[i] = int.Parse(array[i + 1]);
                }

                int currentCol = int.Parse(array[0]);
                int currentRow = 0;

                if (matrix[currentRow, currentCol] == 0)
                {
                    matrix[currentRow, currentCol] = matrix[currentRow, currentCol] | 1;
                }
                else
                {
                    matrix[currentRow, currentCol] = matrix[currentRow, currentCol] & 0;
                }

                for (int i = 0; i < arrayInt.Length; i++)
                {
                    if (arrayInt[i] == -1)
                    {
                        currentCol -= 1;
                        currentRow += 1;

                        if (matrix[currentRow, currentCol] == 0)
                        {
                            matrix[currentRow, currentCol] = matrix[currentRow, currentCol] | 1;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = matrix[currentRow, currentCol] & 0;
                        }
                    }
                    else if (arrayInt[i] == 0)
                    {
                        currentRow += 1;

                        if (matrix[currentRow, currentCol] == 0)
                        {
                            matrix[currentRow, currentCol] = matrix[currentRow, currentCol] | 1;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = matrix[currentRow, currentCol] & 0;
                        }
                    }
                    else
                    {
                        currentRow += 1;
                        currentCol += 1;

                        if (matrix[currentRow, currentCol] == 0)
                        {
                            matrix[currentRow, currentCol] = matrix[currentRow, currentCol] | 1;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = matrix[currentRow, currentCol] & 0;
                        }
                    }

                }

                Console.WriteLine();
            }

            StringBuilder sb = new StringBuilder();

            int sum = 0;

            string g = null;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append(matrix[row, col]);
                }

                g = sb.ToString();
                int decimalNumber = Convert.ToInt32(g, 2);
                sb.Clear();
                sum += decimalNumber;
            }


            string binary = Convert.ToString(sum, 2);
            Console.WriteLine(binary);
            string hexadecimal = Convert.ToString(sum, 16).ToUpper();
            Console.WriteLine(hexadecimal);
        }
    }
}

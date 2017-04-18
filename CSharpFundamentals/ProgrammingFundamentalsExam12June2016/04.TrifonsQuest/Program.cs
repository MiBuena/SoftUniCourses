using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrifonsQuest
{
    class Program
    {
        private static long turns = 0;
        private static long healthPoints = 0;
        private static bool dead = false;
        private static long endRow = 0;
        private static long endCol = 0;


        static void Main(string[] args)
        {
            healthPoints = long.Parse(Console.ReadLine());

            long[] matrixParameters =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

            long rows = matrixParameters[0];

            long cols = matrixParameters[1];

            char[][] matrix = new char[rows][];


            for (int i = 0; i < matrix.Length; i++)
            {
                string inputRow = Console.ReadLine();

                matrix[i] = new char[cols];

                for (int j = 0; j < inputRow.Length; j++)
                {
                    matrix[i][j] = inputRow[j];
                }

            }

            WalkThroughTheMatrix(rows, cols, matrix);

            if (dead)
            {
                Console.WriteLine($"Died at: [{endRow}, {endCol}]");
            }
            else
            {
                Console.WriteLine($"Quest completed!\nHealth: {healthPoints} \nTurns: {turns}");
            }
        }

        private static void WalkThroughTheMatrix(long rows, long cols, char[][] matrix)
        {

            for (long col = 0; col < cols; col++)
            {

                if (dead)
                {
                    break;
                }

                if (col % 2 == 0)
                {
                    for (long row = 0; row < rows; row++)
                    {
                        ProcessChar(matrix[row][col]);

                        turns++;

                        if (healthPoints <= 0)
                        {
                            dead = true;
                            endRow = row;
                            endCol = col;

                            break;
                        }

                    }
                }
                else
                {
                    for (long row = rows - 1; row >= 0; row--)
                    {
                        ProcessChar(matrix[row][col]);

                        turns++;

                        if (healthPoints <= 0)
                        {
                            dead = true;
                            endRow = row;
                            endCol = col;

                            break;
                        }
                    }
                }
            }
        }

        private static void ProcessChar(char c)
        {
            switch (c)
            {
                case 'F':
                    Fight();
                    break;
                case 'H':
                    Heal();
                    break;
                case 'T':
                    Trap();
                    break;
                case 'E':
                    break;
            }
        }


        private static void Trap()
        {
            turns+=2;
        }

        private static void Heal()
        {
            long num = turns/3;

            healthPoints += num;
        }

        private static void Fight()
        {
            long num = turns/2;

            healthPoints -= num;
        }
    }
}

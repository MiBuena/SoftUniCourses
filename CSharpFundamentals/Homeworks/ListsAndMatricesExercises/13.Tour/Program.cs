using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int[] route = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long sum = 0;

            int start = 0;

            for (int i = 0; i < route.Length; i++)
            {
                sum+= matrix[start][route[i]];
                start = route[i];
            }

            Console.WriteLine(sum);
        }
    }
}

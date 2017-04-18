using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04.Tupple
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string[] firstRow = Console.ReadLine().Split(' ');

            string name = firstRow[0] + " " + firstRow[1];

            Tupple<string, string> tupple = new Tupple<string, string>(name, firstRow[2]);

            Console.WriteLine($"{tupple.Item1} -> {tupple.Item2}");

            string[] secondRow = Console.ReadLine().Split(' ');

            Tupple<string, int> tupple2 = new Tupple<string, int>(secondRow[0], int.Parse(secondRow[1]));


            Console.WriteLine($"{tupple2.Item1} -> {tupple2.Item2}");

            string[] thirdRow = Console.ReadLine().Split(' ');

            Tupple<int, double> tupple3 = new Tupple<int, double>(int.Parse(thirdRow[0]), double.Parse(thirdRow[1]));

            Console.WriteLine($"{tupple3.Item1} -> {tupple3.Item2}");

        }
    }
}

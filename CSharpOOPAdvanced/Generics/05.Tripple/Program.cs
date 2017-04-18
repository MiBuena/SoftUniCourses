using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05.Tripple
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string[] firstRow = Console.ReadLine().Split(' ');

            string name = firstRow[0] + " " + firstRow[1];

            Tupple<string, string, string> tupple = new Tupple<string, string, string>(name, firstRow[2], firstRow[3]);

            Console.WriteLine(tupple);


            string[] secondRow = Console.ReadLine().Split(' ');

            bool a = secondRow[2] == "drunk";

            Tupple<string, int, bool> tupple2 = new Tupple<string, int, bool>(secondRow[0], int.Parse(secondRow[1]), a);

            Console.WriteLine(tupple2);

            string[] thirdRow = Console.ReadLine().Split(' ');

            Tupple<string, decimal, string> tupple3 = new Tupple<string, decimal, string>(thirdRow[0], decimal.Parse(thirdRow[1]), thirdRow[2]);


            Console.WriteLine(tupple3);

        }
    }
}

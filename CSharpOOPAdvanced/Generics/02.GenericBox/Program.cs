using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.GenericBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //GenericSwapMethodStrings();

            //GenericSwapMethodIntegers();

            //GenericBoxOfString();

            //GenericBoxInteger();

            //GenericCountMethodString();

            int n = int.Parse(Console.ReadLine());

            var box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();


                box.Add(double.Parse(inputString));
            }

            double doubleToCompare = double.Parse(Console.ReadLine());

            int number = box.CompareByValueDouble(doubleToCompare);

            Console.WriteLine(number);
        }

        private static void GenericCountMethodString()
        {
            int n = int.Parse(Console.ReadLine());

            var box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();


                box.Add(inputString);
            }

            string stringToCompare = Console.ReadLine();

            int number = box.CompareByValue(stringToCompare);

            Console.WriteLine(number);
        }

        private static void GenericBoxInteger()
        {
            int n = int.Parse(Console.ReadLine());

            var box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();


                box.Add(int.Parse(inputString));
            }

            Console.WriteLine(box);
        }

        private static void GenericBoxOfString()
        {
            int n = int.Parse(Console.ReadLine());

            var box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();


                box.Add(inputString);
            }

            Console.WriteLine(box);
        }

        private static void GenericSwapMethodIntegers()
        {
            int n = int.Parse(Console.ReadLine());

            var box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();


                box.Add(int.Parse(inputString));
            }

            List<int> inputParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            box.SwaptElements(inputParameters[0], inputParameters[1]);

            Console.WriteLine(box);
        }

        private static void GenericSwapMethodStrings()
        {
            int n = int.Parse(Console.ReadLine());

            var box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();


                box.Add(inputString);
            }

            List<int> inputParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            box.SwaptElements(inputParameters[0], inputParameters[1]);

            Console.WriteLine(box);
        }
    }
}

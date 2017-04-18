using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                List<string> inputParameters = inputLine.Split(' ').ToList();

           

                double firstNumber = double.Parse(inputParameters[1]);

                double secondNumber = double.Parse(inputParameters[2]);


                var macroClasses = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.Name=="MathUtil");

                foreach (var element in macroClasses)
                {
                    Console.WriteLine("{0:F2}", element.GetMethod(inputParameters[0]).Invoke(null, new object[] {firstNumber, secondNumber}));
                }

            }
        }
    }
}

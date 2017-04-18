using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {
                string inputNumber = Console.ReadLine();

                if (inputNumber == "End")
                {
                    break;
                }

                List<string> inputParameters = inputNumber.Split(' ').ToList();

                int number = int.Parse(inputParameters[0]);

                string unit = inputParameters[1];

                double result = 0;

                if (unit == "Celsius")
                {
                    result = Converter.CelsiusToFahrenheit(number);

                    Console.WriteLine("{0:F2} Fahrenheit", result);

                }
                else
                {
                    result = Converter.FahrenheitToCelcius(number);

                    Console.WriteLine("{0:F2} Celsius", result);
                }

            }
        }
    }
}

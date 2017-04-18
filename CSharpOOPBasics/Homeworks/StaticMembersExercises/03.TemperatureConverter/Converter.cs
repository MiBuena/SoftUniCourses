using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TemperatureConverter
{
    class Converter
    {
        public static double CelsiusToFahrenheit(int inputNumber)
        {
            double fahrenheitNumber = inputNumber*1.8d + 32;

            return fahrenheitNumber;
        }

        public static double FahrenheitToCelcius(int inputNumber)
        {
            double celciusNumber = (inputNumber-32.0)/1.8d;

            return celciusNumber;
        }
    }
}

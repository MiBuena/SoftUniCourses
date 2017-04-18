using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BasicMath
{
    class MathUtil
    {
        public static double Sum(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;

            return sum;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;

            return result;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber*secondNumber;

            return result;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;

            return result;
        }

        public static double Percentage(double firstNumber, double secondNumber)
        {
            double realPercentage = secondNumber/100d;

            double result = firstNumber *realPercentage;

            return result;
        }
    }
}

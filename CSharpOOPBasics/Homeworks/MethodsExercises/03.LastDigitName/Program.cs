using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastDigitName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Number number = new Number(input);

            string result = number.GetLastDigit();

            Console.WriteLine(result);
        }
    }

    public class Number
    {
        public Number(string numberToMethod)
        {
            this.NumberToMethod = numberToMethod;
        }

        public string NumberToMethod { get; set; }

        public string GetLastDigit()
        {
            string digit = this.NumberToMethod.Substring(this.NumberToMethod.Length - 1);

            switch (digit)
            {
                case "1":
                    return "one";
                    break;
                case "2":
                    return "two";
                    break;
                case "3":
                    return "three";
                    break;
                case "4":
                    return "four";
                    break;
                case "5":
                    return "five";
                    break;
                case "6":
                    return "six";
                    break;
                case "7":
                    return "seven";
                    break;
                case "8":
                    return "eight";
                    break;
                case "9":
                    return "nine";
                    break;
                case "0":
                    return "zero";
                    break;
            }

            return null;
        }
    }
}

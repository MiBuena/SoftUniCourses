using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            DecimalNumber transformer = new DecimalNumber();

            Console.WriteLine(transformer.ReverseOrder(number));
        }
    }

    public class DecimalNumber
    {
        public string ReverseOrder(string number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = number.Length-1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }

            string result = sb.ToString();

            return result;
        }
    }
}

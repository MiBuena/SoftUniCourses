using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            List<char> number = Convert.ToString(n, 2).PadLeft(19, '0').ToList();

            r = r%18;

            for (int i = 0; i < r; i++)
            {
                if (f != 18)
                {
                    char exchange = number[number.Count - f - 1];
                    number[number.Count - f - 1] = number[number.Count - f - 2];
                    number[number.Count - f - 2] = exchange;
                }
                else
                {
                    char exchange = number[0];
                    number[0] = number[number.Count - 1];
                    number[number.Count - 1] = exchange;
                }

                char last = number[number.Count - 1];
                number.Insert(0, last);
                number.RemoveAt(number.Count - 1); 
            }

            string secondBinary = string.Join("", number);

            int[] inputInt = new int[secondBinary.Length];

            for (int i = 0; i < secondBinary.Length; i++)
            {
                inputInt[i] = int.Parse(secondBinary[i].ToString());
            }

            int g = inputInt.Length - 1;

            long decimalNumber = 0;

            for (int i = 0; i < inputInt.Length; i++)
            {
                decimalNumber += inputInt[i] * (long)Math.Pow(2, g);
                g--;
            }

            Console.Write(decimalNumber);
        }
    }
}

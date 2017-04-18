using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FriendBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            string a = Convert.ToString(n, 2);

            int[] array = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                array[i] = int.Parse(a[i].ToString());
            }

            StringBuilder friendBits = new StringBuilder();
            StringBuilder regularBits = new StringBuilder();

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    friendBits.Append(array[i]);

                    if (i == array.Length - 2)
                    {
                        friendBits.Append(array[i + 1]);
                    }
                }
                else
                {
                    if ((i!=0)&&(array[i] == array[i - 1]))
                    {
                        friendBits.Append(array[i]);
                    }
                    else
                    {
                         regularBits.Append(array[i]);
                    }

                    if (i == array.Length - 2)
                    {
                        regularBits.Append(array[i + 1]);
                    }  
                }
            }

            string input = friendBits.ToString();

            int[] inputInt = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputInt[i] = int.Parse(input[i].ToString());
            }

            int g = inputInt.Length - 1;

            long decimalNumber = 0;

            for (int i = 0; i < inputInt.Length; i++)
            {
                decimalNumber += inputInt[i] * (long)Math.Pow(2, g);
                g--;
            }

            Console.WriteLine(decimalNumber);

            input = regularBits.ToString();

            inputInt = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputInt[i] = int.Parse(input[i].ToString());
            }

            g = inputInt.Length - 1;

            decimalNumber = 0;

            for (int i = 0; i < inputInt.Length; i++)
            {
                decimalNumber += inputInt[i] * (long)Math.Pow(2, g);
                g--;
            }

            Console.WriteLine(decimalNumber);
        }
    }
}

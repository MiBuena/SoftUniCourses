using System;
using System.Collections.Generic;
using System.Text;

class HayvanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            int numberInt = int.Parse(Console.ReadLine());

            string numberBinary = Convert.ToString(numberInt, 2);

            if (numberBinary.Length < 8)
            {
                numberBinary = numberBinary.PadLeft(8, '0');
            }

            sb.Append(numberBinary);
        }

        string b = sb.ToString();

        List<int> a = new List<int>();


        for (int i = 0; i < b.Length; i++)
        {
            a.Add(int.Parse(b[i].ToString()));
        }

        int level = 0;


        while (true)
        {

            int index = 1 + level*step;

            if (index > a.Count - 1)
            {
                break;
            }


            a[index] = a[index] | 1;

            level++;
        }

        int m = 0;

        StringBuilder sb2 = new StringBuilder();

        for (int i = m; i < a.Count; i++)
        {
            sb2.Append(a[i]);

            if (sb2.Length == 8)
            {
                string input = sb2.ToString();

                int[] inputInt = new int[input.Length];

                for (int p = 0; p < input.Length; p++)
                {
                    inputInt[p] = int.Parse(input[p].ToString());
                }

                int g = inputInt.Length - 1;

                long decimalNumber = 0;

                for (int q = 0; q < inputInt.Length; q++)
                {
                    decimalNumber += inputInt[q] * (long)Math.Pow(2, g);
                    g--;
                }

                Console.WriteLine(decimalNumber);
                sb2.Clear();
            }

            m = i;
        }

        
    }
}

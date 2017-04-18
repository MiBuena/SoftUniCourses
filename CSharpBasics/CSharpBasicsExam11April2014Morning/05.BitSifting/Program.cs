using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitSifting
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong bitsToSieve = ulong.Parse(Console.ReadLine());

            char[] bitsToSieveCharArray = ConvertToBinary(bitsToSieve).ToCharArray();


            ulong numberOfTheSieves = ulong.Parse(Console.ReadLine());

            string [] sievesArray = new string[numberOfTheSieves];

            int a = 0;
            int max = 0;

            for (ulong i = 0; i < numberOfTheSieves; i++)
            {
                ulong number = ulong.Parse(Console.ReadLine());
                
                string sieve = ConvertToBinary(number).PadLeft(bitsToSieveCharArray.Length, '0');

                if (sieve.Length > max)
                {
                    max = sieve.Length;
                }

                sievesArray[i] = sieve;
            }

            if (bitsToSieveCharArray.Length < max)
            {
                bitsToSieveCharArray = ConvertToBinary(bitsToSieve).PadLeft(max, '0').ToCharArray();

                for (int i = 0; i < sievesArray.Length; i++)
                {
                    sievesArray[i] = sievesArray[i].PadLeft(max, '0');
                }
            }


            for (int i = 0; i < bitsToSieveCharArray.Length; i++)
            {
                if (bitsToSieveCharArray[i] == '1')
                {
                    for (int j = 0; j < sievesArray.Length; j++)
                    {
                        if (sievesArray[j][i] == '1')
                        {
                            bitsToSieveCharArray[i] = '0';
                            break;
                        }
                    }

                }

            }

            int zeroCounter = 0;

            for (int i = 0; i < bitsToSieveCharArray.Length; i++)
            {
                if (bitsToSieveCharArray[i] == '1')
                {
                    zeroCounter++;
                }
            }

            Console.WriteLine(zeroCounter);
        }

        public static string ConvertToBinary(ulong value)
        {
            if (value == 0) return "0";
            System.Text.StringBuilder b = new System.Text.StringBuilder();
            while (value != 0)
            {
                b.Insert(0, ((value & 1) == 1) ? '1' : '0');
                value >>= 1;
            }
            return b.ToString();
        }
    }


}

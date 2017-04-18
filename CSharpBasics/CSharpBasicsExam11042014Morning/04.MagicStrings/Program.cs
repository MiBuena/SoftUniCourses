using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MagicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int diff = int.Parse(Console.ReadLine());

            char [] array = {'k', 'n', 'p', 's'};

            char[] firstArray = new char[4];

            char[] secondArray = new char[4];


            bool found = false;

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array.Length; j++)
                {

                    for (int k = 0; k < array.Length; k++)
                    {

                        for (int l = 0; l < array.Length; l++)
                        {

                            for (int m = 0; m < array.Length; m++)
                            {

                                for (int n = 0; n < array.Length; n++)
                                {

                                    for (int o = 0; o < array.Length; o++)
                                    {

                                        for (int p = 0; p < array.Length; p++)
                                        {
                                            firstArray[0] = array[i];
                                            firstArray[1]=array[j];
                                            firstArray[2] = array[k];
                                            firstArray[3] = array[l];


                                            secondArray[0] = array[m];
                                            secondArray[1] = array[n];
                                            secondArray[2] = array[o];
                                            secondArray[3] = array[p];


                                            int sum1 = GenerateSum(firstArray);
                                            int sum2 = GenerateSum(secondArray);

                                            if (Math.Abs(sum1 - sum2) == diff)
                                            {
                                                found = true;

                                                string firstSubstring = string.Join("", firstArray);
                                                string secondSubstring = string.Join("", secondArray);

                                                string[] b = {firstSubstring, secondSubstring};

                                                Array.Sort(b);

                                                Console.Write(firstSubstring);
                                                Console.WriteLine(secondSubstring);
                                            }


                                        }


                                    }


                                }


                            }


                        }

                    }


                }


            }

            if (!found)
            {
               Console.WriteLine("No"); 
            }
        }

        private static int GenerateSum(char[] toString)
        {
            int sumSubset = 0;

            for (int i = 0; i < toString.Length; i++)
            {
                if (toString[i] == 'k')
                {
                    sumSubset += 1;
                }
                else if (toString[i] == 's')
                {
                    sumSubset += 3;
                }
                else if (toString[i] == 'n')
                {
                    sumSubset += 4;
                }
                else if (toString[i] == 'p')
                {
                    sumSubset += 5;
                }
            }

            return sumSubset;
        }
    }
}

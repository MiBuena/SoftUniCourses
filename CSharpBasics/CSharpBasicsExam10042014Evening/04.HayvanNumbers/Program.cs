using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HayvanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());

            bool found = false;

            StringBuilder sb = new StringBuilder();

            for (int firstDigit = 5; firstDigit < 10; firstDigit++)
            {
                for (int secondDigit = 5; secondDigit < 10; secondDigit++)
                {
                    for (int thirdDigit = 5; thirdDigit < 10; thirdDigit++)
                    {
                        for (int fourthDigit = 5; fourthDigit < 10; fourthDigit++)
                        {
                            for (int fifthDigit = 5; fifthDigit < 10; fifthDigit++)
                            {
                                for (int sixthDigit = 5; sixthDigit < 10; sixthDigit++)
                                {
                                    for (int seventhDigit = 5; seventhDigit < 10; seventhDigit++)
                                    {
                                        for (int eighthDigit = 5; eighthDigit < 10; eighthDigit++)
                                        {
                                            for (int ninthDigit = 5; ninthDigit < 10; ninthDigit++)
                                            {

                                                int sumNumber = 0;

                                                sumNumber = firstDigit + secondDigit + thirdDigit + fourthDigit +
                                                            fifthDigit + sixthDigit + seventhDigit + eighthDigit +
                                                            ninthDigit;

                                                bool d = sumNumber == sum;

                                                if (!d)
                                                {
                                                    continue;
                                                }

                                                sb.Append(firstDigit);
                                                sb.Append(secondDigit);
                                                sb.Append(thirdDigit);
                                                sb.Append(fourthDigit);
                                                sb.Append(fifthDigit);
                                                sb.Append(sixthDigit);
                                                sb.Append(seventhDigit);
                                                sb.Append(eighthDigit);
                                                sb.Append(ninthDigit);

                                                string number = sb.ToString();
                                                sb.Clear();

                                                int firstTripple = int.Parse(number.Substring(0, 3));
                                                int secondTripple = int.Parse(number.Substring(3, 3));
                                                int thirdTripple = int.Parse(number.Substring(6, 3));

                                                int firstDifference = thirdTripple - secondTripple;
                                                int secondDifference = secondTripple - firstTripple;
                                                bool a = firstDifference == secondDifference;
                                                bool b = secondDifference == diff;

                                                if (!b)
                                                {
                                                    continue;
                                                }

                                                bool e = firstTripple <= secondTripple;
                                                bool g = secondTripple <= thirdTripple;

                                                if (a && b && d && e && g)
                                                {
                                                    found = true;
                                                    Console.WriteLine(number);
                                                }
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
    }
}
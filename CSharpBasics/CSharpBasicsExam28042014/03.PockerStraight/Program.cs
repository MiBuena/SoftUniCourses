using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PockerStraight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());

            string[] a = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

            string b = "CDHS";

            int g = 10;

            for (int m = 0; m < 5; m++)
            {
                for (int i = 1; i < 4; i++)
                {
                    for (int j = 2; j < 15; j++)
                    {
                        long p = g*j + i;
                    }
                }
            }

            int q = 1;
            int r = 1;
            int s = 1;
            int t = 1;

            int counter = 0;

            for (int firstCard = 1; firstCard < 11; firstCard++)
            {

                for (int firstCardSuit = 1; firstCardSuit < 5; firstCardSuit++)
                {
                    for (int secondCardSuit = 1; secondCardSuit < 5; secondCardSuit++)
                    {
                        for (int thirdCardSuit = 1; thirdCardSuit < 5; thirdCardSuit++)
                        {
                            for (int fourthCardSuit = 1; fourthCardSuit < 5; fourthCardSuit++)
                            {
                                for (int fifthCardSuit = 1; fifthCardSuit < 5; fifthCardSuit++)
                                {
                                    long sum = 10*firstCard + firstCardSuit +
                                               20*(firstCard + 1) + secondCardSuit +
                                               30*(firstCard + 2) + thirdCardSuit +
                                               40*(firstCard + 3) + fourthCardSuit +
                                               50*(firstCard + 4) + fifthCardSuit;

                                    if (sum == weight)
                                    {
                                        counter++;
                                    }
                                }
                            }
                        }

                    }
                }
            }

            Console.WriteLine(counter);

        }
    }
}

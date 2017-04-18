using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FiveSpecialLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            bool found = false;

            for (char i = 'a'; i <= 'e'; i++)
            {
                for (char m = 'a'; m <= 'e'; m++)
                {
                    for (char j = 'a'; j <= 'e'; j++)
                    {
                        for (char k = 'a'; k <= 'e'; k++)
                        {
                            for (char l = 'a'; l <= 'e'; l++)
                            {
                                List<char> combination = new List<char>();

                                combination.Add(i);
                                combination.Add(m);
                                combination.Add(j);
                                combination.Add(k);
                                combination.Add(l);

                                string a = string.Join("", combination);

                                int weight = 0;

                                for (int n = combination.Count-1; n >= 0; n--)
                                {
                                    char letter = combination[n];

                                    List<char> list = combination.Take(n).ToList();

                                    if (list.Contains(letter))
                                    {
                                        combination.RemoveAt(n);
                                    }
                                }

                                for (int n = 0; n < combination.Count; n++)
                                {
                                    int addNumber = 0;

                                    if (combination[n] == 'a')
                                    {
                                        addNumber = 5;
                                    }
                                    else if (combination[n] == 'b')
                                    {
                                        addNumber = -12;
                                    }
                                    else if (combination[n] == 'c')
                                    {
                                        addNumber = 47;
                                    }
                                    else if (combination[n] == 'd')
                                    {
                                        addNumber = 7;
                                    }
                                    else if (combination[n] == 'e')
                                    {
                                        addNumber = -32;
                                    }

                                    weight += (n+1)*addNumber;
                                }

                                if (weight >= start && weight <= end)
                                {
                                    Console.Write("{0} ", a);
                                    found = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!found)
            {
                Console.Write("No");
            }
        }
    }
}

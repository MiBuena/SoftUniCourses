using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MelonsAndWatermelons
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            long melons = 0;
            long watermelons = 0;

            int g = s + d;

            List<int> a = new List<int>();

            if (g <= 7)
            {
                int p = s + d - 1;

                for (int i = s; i <=p; i++)
                {
                    a.Add(i);
                }

                for (int i = 0; i < a.Count; i++)
                {
                    switch (a[i])
                    {
                        case 1:
                            watermelons++;
                            break;
                        case 2:
                            melons += 2;
                            break;
                        case 3:
                            watermelons++;
                            melons++;
                            break;
                        case 4:
                            watermelons += 2;
                            break;
                        case 5:
                            watermelons += 2;
                            melons += 2;
                            break;
                        case 6:
                            watermelons++;
                            melons += 2;
                            break;
                        default:
                            break;
                    }
                }
            }
            else if((g>7)&&(d<7))
            {
                for (int i = s; i <= s-1+d; i++)
                {
                    int m = i;

                    if (m > 7)
                    {
                        m = i - 7;
                    }

                    a.Add(m);
                }

                for (int i = 0; i < a.Count; i++)
                {
                    switch (a[i])
                    {
                        case 1:
                            watermelons++;
                            break;
                        case 2:
                            melons += 2;
                            break;
                        case 3:
                            watermelons++;
                            melons++;
                            break;
                        case 4:
                            watermelons += 2;
                            break;
                        case 5:
                            watermelons += 2;
                            melons += 2;
                            break;
                        case 6:
                            watermelons++;
                            melons += 2;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                int q = d/7;
                d = d%7;

                for (int i = s; i <= s - 1 + d; i++)
                {
                    int m = i;

                    if (m > 7)
                    {
                        m = i - 7;
                    }

                    a.Add(m);
                }

                for (int i = 0; i < a.Count; i++)
                {
                    switch (a[i])
                    {
                        case 1:
                            watermelons++;
                            break;
                        case 2:
                            melons += 2;
                            break;
                        case 3:
                            watermelons++;
                            melons++;
                            break;
                        case 4:
                            watermelons += 2;
                            break;
                        case 5:
                            watermelons += 2;
                            melons += 2;
                            break;
                        case 6:
                            watermelons++;
                            melons += 2;
                            break;
                        default:
                            break;
                    }
                }

                melons += q * 7;
                watermelons += q * 7; 
            }

            if (melons > watermelons)
            {
                long h = melons - watermelons;
                Console.WriteLine("{0} more melons", h);
            }
            else if (watermelons > melons)
            {
                long h = watermelons - melons;
                Console.WriteLine("{0} more watermelons", h);
            }
            else
            {
                Console.WriteLine("Equal amount: {0}", watermelons);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnterNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
 
            for (int i = 1; i < 10; i++)
            {
                string a = Console.ReadLine();
                ReadNumber(1, 100, a, i);
            }
        }

        private static void ReadNumber(int b, int c, string a, int i)
        {
                try
                {
                    int.Parse(a);
                    int d = int.Parse(a);

                    if (d > c || d < b)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    i--;
                    Console.Error.WriteLine("Number out of range");
                }
                catch (FormatException)
                {
                    i--;
                    Console.Error.WriteLine("Wrong format");
                }
                catch (OverflowException)
                {
                    i--;
                    Console.Error.WriteLine("Number too large");
                }
            }
        }
    }


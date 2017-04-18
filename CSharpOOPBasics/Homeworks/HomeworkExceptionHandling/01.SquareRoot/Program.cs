using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
           string a = Console.ReadLine();

            try
            {

                int.Parse(a);
                double b = double.Parse(a);

                if (b < 0)
                {
                    throw new ArgumentOutOfRangeException("b", "b can not be negative");
                }

                double c = Math.Sqrt(b);
                Console.WriteLine(c);

            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.ParamName, "Number is negative");
            }

            finally
            {
                Console.WriteLine("Good");
            }
           
        }
    }
}

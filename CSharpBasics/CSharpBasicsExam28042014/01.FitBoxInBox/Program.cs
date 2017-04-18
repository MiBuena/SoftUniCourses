using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FitBoxInBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());

            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());

            long a = a1*b1*c1;
            long b = a2*b2*c2;



            if (a < b)
            {
                if ((a1 < a2) && (b1 < b2) && (c1 < c2))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a1, b1, c1, a2, b2, c2);
                }
                
                if ((a1 < a2) && (b1 < c2) && (c1 < b2))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a1, b1, c1, a2, c2, b2);
                }
                
                if ((a1 < c2) && (b1 < a2) && (c1 < b2))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a1, b1, c1, c2, a2, b2);
                }
                
                if ((a1 < b2) && (b1 < c2) && (c1 < a2))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a1, b1, c1, b2, c2, a2); 
                }
                
                if ((a1 < c2) && (b1 < b2) && (c1 < a2))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a1, b1, c1, c2, b2, a2); 
                }
                
                if ((a1 < b2) && (b1 < a2) && (c1 < c2))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a1, b1, c1, b2, a2, c2);
                }

            }
            else if(a>b)
            {
                if ((a2 < a1) && (b2 < b1) && (c2 < c1))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a2, b2, c2, a1, b1, c1);
                }
                
                if ((a2 < a1) && (b2 < c1) && (c2 < b1))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a2, b2, c2, a1, c1, b1);
                }
                
                if ((a2 < c1) && (b2 < a1) && (c2 < b1))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a2, b2, c2, c1, a1, b1);
                }
                
                if ((a2 < b1) && (b2 < c1) && (c2 < a1))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a2, b2, c2, b1, c1, a1);
                }
                
                if ((a2 < c1) && (b2 < b1) && (c2 < a1))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a2, b2, c2, c1, b1, a1);
                }
                
                if ((a2 < b1) && (b2 < a1) && (c2 < c1))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", a2, b2, c2, b1, a1, c1);
                }

            }
           
            

        }
    }
}

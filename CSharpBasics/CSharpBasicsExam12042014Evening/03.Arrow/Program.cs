using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string a = new string('.', number/2);
            string b = new string('#', number);

            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(a);
            string c = new string('.', number - 2);

            for (int i = 0; i < number-2; i++)
            {
                Console.Write(a);
                Console.Write("#");
                Console.Write(c);
                Console.Write("#");
                Console.WriteLine(a);
            }

            string d = new string('#', number/2+1);

            Console.Write(d);
            Console.Write(c);
            Console.WriteLine(d);

            int g = 1;
            int m = number+(number - 1) - 2- 2*g;

            string p = new string('.', g);

            for (int i = 0; i < number-2; i++)
            {
                p = new string('.', g);
                string q = new string('.', m);

                Console.Write(p);
                Console.Write("#");
                Console.Write(q);
                Console.Write("#");
                Console.WriteLine(p);

                g++;
                m-=2;
            }

            p = new string('.', g);

            Console.Write(p);
            Console.Write("#");
            Console.Write(p);
        }
    }
}

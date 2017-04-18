using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eclipse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string a = new string(' ', 1);
            string b = new string('*', 2*n - 2);
            string e = new string(' ', n - 1);
            string f = new string('-', n - 1);

            Console.Write(a);
            Console.Write(b);
            Console.Write(a);
            Console.Write(e);
            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(a);

            string c = "*";
            string d = new string('/', 2*n-2);

            for (int i = 0; i < n-2; i++)
            {
                if (i ==(n/2)-1)
                {
                    Console.Write(c);
                    Console.Write(d);
                    Console.Write(c);
                    Console.Write(f);
                    Console.Write(c);
                    Console.Write(d);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.Write(c);
                    Console.Write(d);
                    Console.Write(c);
                    Console.Write(e);
                    Console.Write(c);
                    Console.Write(d);
                    Console.WriteLine(c);
                }

               
            }

            Console.Write(a);
            Console.Write(b);
            Console.Write(a);
            Console.Write(e);
            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(a);
        }
    }
}

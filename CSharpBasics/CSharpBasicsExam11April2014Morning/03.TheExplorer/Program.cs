using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TheExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int d = n/2;
            int e = d-1;

            string a = new string('-', d);
            string b = new string('*', 1);

            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(a);

            int f = 1;

            for (int i = 0; i < d; i++)
            {

                string c = new string('-', e);
                string g = new string('-', f);

                Console.Write(c);
                Console.Write('*');
                Console.Write(g);
                Console.Write('*');
                Console.WriteLine(c);

                e--;
                f+=2;
            }

            e+=2;
            f -= 4;

            for (int i = 0; i < d-1; i++)
            {
                string c = new string('-', e);
                string g = new string('-', f);

                Console.Write(c);
                Console.Write('*');
                Console.Write(g);
                Console.Write('*');
                Console.WriteLine(c);

                e++;
                f -= 2;
            }

            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(a);
        }
    }
}

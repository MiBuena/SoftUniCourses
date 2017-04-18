using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PandsScotland
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int m = 0;
            int p = 2;
            int k = 0;

            for (int i = 0; i < n/2; i++)
            {
                string b = new string('~', k++);
                Console.Write(b);
                Console.Write(alphabet[m]);
                m++;

                if (m > 25)
                {
                    m = 0;
                }

                string a = new string('#', n-p);
                Console.Write(a);
                Console.Write(alphabet[m]);
                m++;

                if (m > 25)
                {
                    m = 0;
                }

                Console.Write(b);

                p += 2;

                Console.WriteLine();
            }

            string q = new string('-', k);
            Console.Write(q);
            Console.Write(alphabet[m]);
            m++;
            if (m > 25)
            {
                m = 0;
            }

            Console.Write(q);

            k--;

            Console.WriteLine();
            
            p = 1;

            for (int i = 0; i < n / 2; i++)
            {
                string b = new string('~', k--);
                Console.Write(b);
                Console.Write(alphabet[m]);

                m++;
                if (m > 25)
                {
                    m = 0;
                }

                string a = new string('#', p);
                Console.Write(a);
                Console.Write(alphabet[m]);

                m++;
                if (m > 25)
                {
                    m = 0;
                }

                Console.Write(b);

                p += 2;

                Console.WriteLine();
            }
        }
    }
}

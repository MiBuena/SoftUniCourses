using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SequenceOfKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            List<string> b = a.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            List<int> c = new List<int>();

            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < b.Count; i++)
            {
                c.Add(int.Parse(b[i]));
            }

            int g = 1;

            for (int i = 0; i <= c.Count-k; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    if (c[i] == c[i + j])
                    {
                        g++;
                    }
                }

                if (g == k)
                {
                    for (int j = i; j < i+k; j++)
                    {
                        c.RemoveAt(i);
                    }

                    i--;
                }

                g = 1;
            }

            for (int i = 0; i < c.Count; i++)
            {
                Console.Write("{0} ", c[i]);
            }
        }
    }
}

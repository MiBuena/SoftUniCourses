using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Pesho", 12, "littlepesho@qkiq");
            Person b = new Person("Dancho", 15);

            Console.WriteLine(a.ToString());
            Console.WriteLine();
            Console.WriteLine(b.ToString());

            try
            {
                Person c = new Person("sdf", 10, "adsf");
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine(ex.ParamName);
            }

            try
            {
                Person d = new Person("asdkjh", -12, "aslkdj@alksjd");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book("Pod Igoto", "Ivan Vazov", 15.90M);
            Console.WriteLine(a);

            GoldenEditionBook b = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90M);

            Console.WriteLine(b);
        }
    }
}

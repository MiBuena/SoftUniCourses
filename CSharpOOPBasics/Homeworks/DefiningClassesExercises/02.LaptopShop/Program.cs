using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            try
            {
                Laptop a = new Laptop("Lenovo Yoga 2 Pro", 2259.00M, "Lenovo",
                    "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400",
                    "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                    new Battery("Li-Ion", 4, 2550), 4.5d);
                Console.WriteLine(a.ToString());
                Console.WriteLine();

                Laptop b = new Laptop("HP 250 G2", -699.00M);
                Console.WriteLine(b.ToString());
                Console.WriteLine();

                Laptop c = new Laptop("HP", 92, "Intel HD Graphics 4400", "128GB SSD", "14\"",
                    new Battery("Ni-MH", 3, 2550), 2.5);
                Console.WriteLine(c.ToString());

                Laptop d = new Laptop("", -5);

                Console.WriteLine(d.ToString());

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.ParamName + " " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

        }
    }
}

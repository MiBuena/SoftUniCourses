using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Computer a = new Computer("Second", new Component("Logitech", 5), new Component("Logitech", 20), new Component("Intel", 100), new Component("Motherboard", 50));
                Computer b = new Computer("First", new Component("Intel", 100), new Component("Motherboard", 50));
                Computer c = new Computer("Third", new Component("Logitech", 25), new Component("Logitech", 40), new Component("Intel", 200), new Component("Motherboard", 50));

                List<Computer> collection = new List<Computer>();
                collection.Add(a);
                collection.Add(b);
                collection.Add(c);

                var orderedCollection = collection.OrderBy(x => x.Price);

                foreach (var element in orderedCollection)
                {
                    Console.WriteLine(element);
                    Console.WriteLine();
                }

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}

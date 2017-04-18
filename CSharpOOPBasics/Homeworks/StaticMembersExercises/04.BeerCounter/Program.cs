using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeerCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                List<int> inputParameters = inputLine.Split(' ').Select(int.Parse).ToList();

                BeerCounter.BuyBeer(inputParameters[0]);
                BeerCounter.DrinkBeer(inputParameters[1]);
            }

            Console.Write(BeerCounter.BeerInStock + " ");

            Console.WriteLine(BeerCounter.BeersDrankCount);
        }
    }
}

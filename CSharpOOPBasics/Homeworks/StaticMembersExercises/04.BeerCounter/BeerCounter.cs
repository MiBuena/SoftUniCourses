using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeerCounter
{
    class BeerCounter
    {
        public static int BeerInStock { get; set; }

        public static int BeersDrankCount { get; set; }

        public static void BuyBeer(int bottlesCount)
        {
            BeerCounter.BeerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            BeerCounter.BeersDrankCount += bottlesCount;
            BeerCounter.BeerInStock -= bottlesCount;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardsProject;

namespace _07.GetDeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var suitValues = Enum.GetValues(typeof(CardSuit));

            var rankValues = Enum.GetValues(typeof(CardRank));

            foreach (var suit in suitValues)
            {
                foreach (var rank in rankValues)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }
    }
}

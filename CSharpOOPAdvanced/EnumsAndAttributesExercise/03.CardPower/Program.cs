using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardsProject;

namespace _03.CardPower
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardRankString = Console.ReadLine();

            string cardSuitString = Console.ReadLine();

            var cardRank = Enum.Parse(typeof(CardRank), cardRankString);


            var cardSuit = Enum.Parse(typeof(CardSuit), cardSuitString);


            Card card = new Card()
            {
                CardRank = (CardRank)cardRank,
                CardSuit = (CardSuit)cardSuit
            };

            Console.WriteLine(card);
        }
    }
}

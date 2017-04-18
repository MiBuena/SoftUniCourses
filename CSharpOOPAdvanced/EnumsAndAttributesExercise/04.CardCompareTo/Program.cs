using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardsProject;

namespace _04.CardCompareTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstCardRankString = Console.ReadLine();

            string firstCardSuitString = Console.ReadLine();

            var firstCardRank = Enum.Parse(typeof(CardRank), firstCardRankString);


            var firstCardSuit = Enum.Parse(typeof(CardSuit), firstCardSuitString);

            Card first = new Card()
            {
                CardRank = (CardRank)firstCardRank,
                CardSuit = (CardSuit)firstCardSuit
            };


            string secondCardRankString = Console.ReadLine();

            string secondCardSuitString = Console.ReadLine();

            var secondCardRank = Enum.Parse(typeof(CardRank), secondCardRankString);


            var secondCardSuit = Enum.Parse(typeof(CardSuit), secondCardSuitString);

            Card second = new Card()
            {
                CardRank = (CardRank)secondCardRank,
                CardSuit = (CardSuit)secondCardSuit
            };


            SortedSet<Card> newSortedSet = new SortedSet<Card>();

            newSortedSet.Add(first);
            newSortedSet.Add(second);

            Console.WriteLine(newSortedSet.LastOrDefault());
        }
    }
}

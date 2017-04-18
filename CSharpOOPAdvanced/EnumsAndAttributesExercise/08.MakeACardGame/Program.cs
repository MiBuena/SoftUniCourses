using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardsProject;

namespace _08.MakeACardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();

            string secondPlayerName = Console.ReadLine();

            ICollection<Card> deckOfCards = new List<Card>();

            deckOfCards = FillDeckOfCards(deckOfCards);

            List<Player> players = new List<Player>();


            players.Add(new Player()
            {
                Name = firstPlayerName
            });

            players.Add(new Player()
            {
                Name = secondPlayerName
            });

            for (int i = 0; i < players.Count; i++)
            {
                while (true)
                {
                    if (players[i].CardSet.Count >= 5)
                    {
                        break;
                    }

                    string[] cardparameters = Console.ReadLine().Split(' ');


                    bool rankExists = Enum.IsDefined(typeof(CardRank), cardparameters[0]);


                    bool suitExists = Enum.IsDefined(typeof(CardSuit), cardparameters[2]);

                    if (!suitExists || !rankExists)
                    {
                        Console.WriteLine("No such card exists.");
                    }
                    else
                    {
                        CardRank cardRank = (CardRank)Enum.Parse(typeof(CardRank), cardparameters[0]);

                        CardSuit cardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), cardparameters[2]);


                        AddACard((CardSuit)cardSuit, (CardRank)cardRank, players, deckOfCards, i);
                    }
                }
            }

            players.Sort();

            var winner = players[1];

            Console.WriteLine($"{winner.Name} wins with {winner.CardSet.Max.CardRank} of {winner.CardSet.Max.CardSuit}.");
        }

        private static void AddACard(CardSuit newCardSuit, CardRank newCardRank, List<Player> players,
            ICollection<Card> deckOfCards, int playerNumber)
        {
            Card newCard = deckOfCards.FirstOrDefault(x => x.CardRank == newCardRank && x.CardSuit == newCardSuit);

            if (newCard == null)
            {

                Console.WriteLine("Card is not in the deck.");

            }
            else
            {
                players[playerNumber].CardSet.Add(newCard);
                deckOfCards.Remove(newCard);
            }

        }


        private static ICollection<Card> FillDeckOfCards(ICollection<Card> deckOfCards)
        {
            var suitValues = Enum.GetValues(typeof(CardSuit));

            var rankValues = Enum.GetValues(typeof(CardsProject.CardRank));

            foreach (var suit in suitValues)
            {
                foreach (var rank in rankValues)
                {
                    Card newCard = new Card()
                    {
                        CardRank = (CardsProject.CardRank)rank,
                        CardSuit = (CardSuit)suit
                    };

                    deckOfCards.Add(newCard);
                }
            }

            return deckOfCards;
        }
    }
}

using System;
using System.Collections.Generic;

namespace CardsProject
{
    public class Player : IComparable<Player>
    {
        public Player()
        {
            this.CardSet = new SortedSet<Card>();
        }
        public string Name { get; set; }

        public SortedSet<Card> CardSet { get; set; }

        public int CompareTo(Player other)
        {
            var thisPlayerMaxCard = this.CardSet.Max;
            var otherPlayerMaxCard = other.CardSet.Max;

            return thisPlayerMaxCard.Power.CompareTo(otherPlayerMaxCard.Power);
        }
    }
}

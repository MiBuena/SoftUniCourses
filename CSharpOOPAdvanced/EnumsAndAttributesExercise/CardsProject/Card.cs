using System;

namespace CardsProject
{
    public class Card : IComparable<Card>
    {
        public CardSuit CardSuit { get; set; }

        public CardRank CardRank { get; set; }

        public int Power
        {
            get { return (int) this.CardRank + (int) this.CardSuit; }
        }
        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }

        public override string ToString()
        {
            string card=string.Format($"Card name: {this.CardRank} of {this.CardSuit}; Card power: {(int)this.CardRank + (int)this.CardSuit}");

            return card;
        }
    }
}

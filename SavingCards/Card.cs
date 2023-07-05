using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingCards
{
    class Card
    {
        public override string ToString()
        {
            return Name;
        }
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get
            {
                return Value + " of " + Suit;
            }
        }
    }
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }
    enum Values
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
}

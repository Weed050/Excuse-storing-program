using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingCards
{
    class DeckOfCards
    {
        public List<Card> Cards;
        public DeckOfCards(List<Card> cards)
        {
            Cards = cards;
        }
        public DeckOfCards()
        {
            Cards = new List<Card>(new Card[]{ });
        }
        public void AddCard(Card card) 
        { 
            Cards.Add(card);
        }
    }
}

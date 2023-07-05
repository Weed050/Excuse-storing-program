using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingCards
{
    
     class Deck
    {
        [JsonProperty]
        private List<Card> cards;
        public int Count { get { return cards.Count(); } }

        private Random random = new Random();
        public void Add(Card cardToAdd)
            => cards.Add(cardToAdd);

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }
        public void Shuffle()
        {
            /// moja wersja
            //for (int i = 0; i < cards.Count; i++)
            //{
            //    int n = random.Next(cards.Count + 1);
            //    Card card = cards[i];
            //    cards[i] = cards[n];
            //    cards[n] = card;
            //}

            /// wersja z książki
                List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count());
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }
        public IEnumerable<string> GetCardNames()
        {
            //string[] Names = new string[cards.Count()];
            List<string> names = new List<string>();
            foreach (Card card in cards)
            {
                names.Add(card.Name);
            }
            return names;
        }
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }
        public Deck(IEnumerable<Card> initialCards)
            => this.cards = new List<Card>(initialCards);

        public void Sort()
            => cards.Sort(new SortByValuesNSuits());
    }
}

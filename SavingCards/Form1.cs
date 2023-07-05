using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace SavingCards
{
    public partial class Form1 : Form
    {
        Deck stock;
        const string path = "Deck.json";
        public Form1()
        {
            InitializeComponent();
            ClearStock();
            List<DeckOfCards> listOfDecks = new List<DeckOfCards>()
            {  new DeckOfCards(),
               new DeckOfCards(),
               new DeckOfCards(),
             };

        }
        Random random = new Random();

        private void ClearStock()
          => stock = new Deck(new Card[] { });

        private List<Card> RandomListOfCards(int number)
        {
            List<Card> deckToReturn = new List<Card>();
            for (int i = 0; i < number; i++)
                deckToReturn.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            return deckToReturn;
        }
        private void DealCards(List<Card> deckToDeal, string Title)
        {
            Debug.WriteLine(Title);
            foreach (Card card in deckToDeal)
                Debug.WriteLine(card.Name);
            Debug.WriteLine("----------------------");
        }

        private void createNGenerateDeckBtn_Click(object sender, EventArgs e)
        {
            List<Card> stockCard = RandomListOfCards(3);
            foreach (Card card in stockCard)
                stock.Add(card);
            string cardsToSend = JsonConvert.SerializeObject(stockCard);
            File.WriteAllText(path, cardsToSend);
            DealCards(stockCard, "Zapisane karty:");
        }

        private void getDeckBtn_Click(object sender, EventArgs e)
        {
            //string stockDeser = File.ReadAllText(path);
            //this.stock = new(new Card[] { });
            ////this.stock = jsonconvert.deserializeobject<deck>(stockdeser);
            //for (int i = 0; i < JsonConvert.DeserializeObject<Deck>(stockDeser).Count; i++)
            //{
            //    Card cardToAdd = JsonConvert.DeserializeObject<Deck>(stockDeser).Deal(i);
            //    this.stock.Add(cardToAdd);
            //}
            ////while(stock1)

            //DealCards(stock, "Wczytane karty:");
            stock = new(new Card[] { });

            List<Card> listOfCards = JsonConvert.DeserializeObject<List<Card>>(File.ReadAllText(path));
            foreach (var card in listOfCards)
                stock.Add(card);
            DealCards(listOfCards, "Karty z pliku:");
        }

        private void save3timesBtn_Click(object sender, EventArgs e)
        {
            DeckOfCards deck;
            List<DeckOfCards> decks = new List<DeckOfCards>();
            for (int i = 0; i < 5; i++)
            {
                deck = new DeckOfCards(RandomListOfCards(3));
               decks.Add(deck);
            }
            string decksJson = JsonConvert.SerializeObject(decks);
                File.WriteAllText("DecksOfCards.dat", decksJson);

            for (int i = 0; i < decks.Count; i++)
            {
                int z = i + 1;

            DealCards(decks[i].Cards,"Zapisany zestaw nr "+ z +":");
            }
        }

        private void open3DecksBtn_Click(object sender, EventArgs e)
        {
           string content = File.ReadAllText("DecksOfCards.dat");
            var listOfDecks = JsonConvert.DeserializeObject<List<DeckOfCards>>(content);
            for (int i = 0; i < listOfDecks.Count; i++)
            {
                int z = i+1;
                DealCards(listOfDecks[i].Cards, "Zawartoœæ zestawu nr "+ z +":");
            }
        }
    }
}
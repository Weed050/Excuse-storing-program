using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace SavingCards
{
    public partial class Form1 : Form
    {
        byte[] file1 = new byte[50];
        byte[] file2 = new byte[50];
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
        string pathJSONDirectory = @"C:\C# pliki tekstowe\Deck.json";
        private void save3timesBtn_Click(object sender, EventArgs e)
        {
            DeckOfCards deck;
            List<DeckOfCards> decks = new List<DeckOfCards>();
            for (int i = 0; i < 1; i++)
            {
                deck = new DeckOfCards(RandomListOfCards(3));
                decks.Add(deck);
            }
            string decksJson = JsonConvert.SerializeObject(decks);
            File.WriteAllText(pathJSONDirectory, decksJson);

            for (int i = 0; i < decks.Count; i++)
            {
                int z = i + 1;

                DealCards(decks[i].Cards, "Zapisany zestaw nr " + z + ":");
            }
        }

        private void open3DecksBtn_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("DecksOfCards.dat");
            var listOfDecks = JsonConvert.DeserializeObject<List<DeckOfCards>>(content);
            for (int i = 0; i < listOfDecks.Count; i++)
            {
                int z = i + 1;
                DealCards(listOfDecks[i].Cards, "Zawartoœæ zestawu nr " + z + ":");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = new Card(Suits.Spades, Values.Ace);
            Card card1 = new Card(Suits.Hearts, Values.Four);
            //byte[] card01 = card;
            File.Delete("plikNr1.txt");
            File.Delete("plikNr2.txt");
            File.WriteAllText("plikNr1.txt", JsonConvert.SerializeObject(card));
            File.WriteAllText("plikNr2.txt", JsonConvert.SerializeObject(card1));
            file1 = File.ReadAllBytes("plikNr1.txt");
            file2 = File.ReadAllBytes("plikNr2.txt");
            for (int i = 0; i < file1.Length; i++)
            {
                int z = i + 1;
                if (file1[i] != file2[i])
                {
                    Debug.WriteLine("Znaleziono ró¿nice w elemencie {0}:  {1} i {2}", i, file1[i], file2[i]);

                }
            }
            Debug.WriteLine("Pierwsza karta to {0} a druga to {1}", card.Name, card1.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //byte bit1 = (byte)Suits.Hearts;
            file1[8] = (byte)49;
            file1[18] = (byte)52;
            file2[8] = (byte)48;
            file2[18] = (byte)51;
            File.Delete("plikNr1.txt");
            File.Delete("plikNr2.txt");
            File.WriteAllBytes("plikNr1.txt", file1);
            File.WriteAllBytes("plikNr2.txt", file2);
            Card card1 = JsonConvert.DeserializeObject<Card>((string)File.ReadAllText("plikNr1.txt"));
            Card card2 = JsonConvert.DeserializeObject<Card>(File.ReadAllText("plikNr2.txt"));
            Debug.WriteLine("Karta pierwsza to {0} a druga karta to {1}", card1.Name, card2.Name);

        }

        static void ConvertToHexAndSaveToFile(string inputFilePath, string outputFilePath)
        {
            try
            {
                // Odczytanie zawartoœci pliku wejœciowego
                string text = File.ReadAllText(inputFilePath);

                // Zamiana znaków o wartoœci poni¿ej 32 na kropki
                string sanitizedText = SanitizeText(text);

                // Konwersja znaków na wartoœci szesnastkowe
                string hexString = ConvertToHexString(sanitizedText);

                // Zapisywanie wyników do pliku tekstowego
                SaveHexToFile(hexString, outputFilePath);

                Debug.WriteLine(string.Empty);
                Debug.WriteLine("Pomyœlnie przekonwertowano i zapisano dane w pliku.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Wyst¹pi³ b³¹d: " + ex.Message);
            }
        }

        static string SanitizeText(string text)
        {
            StringBuilder sanitizedText = new StringBuilder();
            foreach (char c in text)
            {
                if (c < 32)
                {
                    sanitizedText.Append('.');
                }
                else
                {
                    sanitizedText.Append(c);
                }
            }
            return sanitizedText.ToString();
        }

        static string ConvertToHexString(string text)
        {
            StringBuilder hexString = new StringBuilder();
            foreach (char c in text)
            {
                hexString.AppendFormat(" {0:X2}", (int)c);
            }
            return hexString.ToString();
        }

        static void SaveHexToFile(string hexString, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                int count = 0;
                bool end = false;
                for (int i = 0; i < hexString.Length; i++)
                {
                    // Wyœwietlanie liczby wyœwietlonych znaków przed lini¹
                    if (count % 32 == 0)
                    {
                        writer.Write($"{count:0000}: ");
                        Debug.Write($"{count:0000}: ");
                    }

                    writer.Write(hexString[i]);
                    Debug.Write(hexString[i]);
                    count++;

                    // Dodawanie przerwy co 16 znaków
                    if (count % 16 == 0)
                    {
                        if (!end)
                        {
                            writer.Write(" --- ");
                            Debug.Write(" --- ");
                            end = true;
                        }
                        else
                            end = false;

                    }

                    // Ograniczanie maksymalnej d³ugoœci linii do 32 znaków
                    if (count % 32 == 0)
                    {
                        writer.WriteLine();
                        Debug.WriteLine(string.Empty);
                    }
                }
            }
        }


        private void converdToHexBtn_Click(object sender, EventArgs e)
        {
            string outputFilePath = @"C:\C# pliki tekstowe\output.txt";

            ConvertToHexAndSaveToFile(pathJSONDirectory, outputFilePath);

        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pliki tekstowe (*.txt) |*.txt|" + "Pliki JSON (*.json)|*.json|" + "Wszystkie pliki (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathJSONDirectory = openFileDialog1.FileName;
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ConvertToHexAndSaveToFile(pathJSONDirectory, saveFileDialog1.FileName);
            }
        }
    }
}
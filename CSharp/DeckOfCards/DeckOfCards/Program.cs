using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            for (int x = 0; x <= 3; x++)
            {
                Suit s = new Suit(x);
                for (int y = 1; y <= 13; y++)
                {
                    Card c = new Card(y, s);
                    Cards.Add(c);
                }
            }
        }

        public List<Card> Cards { get; private set; }

        public void Shuffle()
        {
            //TODO 
        }

        public void Draw()
        {
            //TODO
        }
    }

    public class Card
    {
        public string Name { get; private set; }
        public Suit Suit { get; private set; }

        public Card(int cardId, Suit s)
        {
            Suit = s;
            switch (cardId)
            {
                case 1:
                    Name = "Ace";
                    break;
                case 2:
                    Name = "Two";
                    break;
                case 3:
                    Name = "Three";
                    break;
                case 4:
                    Name = "Four";
                    break;
                case 5:
                    Name = "Five";
                    break;
                case 6:
                    Name = "Six";
                    break;
                case 7:
                    Name = "Seven";
                    break;
                case 8:
                    Name = "Eight";
                    break;
                case 9:
                    Name = "Nine";
                    break;
                case 10:
                    Name = "Ten";
                    break;
                case 11:
                    Name = "Jack";
                    break;
                case 12:
                    Name = "Queen";
                    break;
                case 13:
                    Name = "King";
                    break;
                default:
                    throw new NotImplementedException(String.Format("Id {0} is not supported.", cardId));
            }
        }
    }

    public class Suit
    {
        public string Name { get; set; }

        public Suit(int id)
        {
            switch (id)
            {
                case 0:
                    Name = "Hearts";
                    break;
                case 1:
                    Name = "Diamonds";
                    break;
                case 2:
                    Name = "Spades";
                    break;
                case 3:
                    Name = "Clubs";
                    break;
                default:
                    throw new NotImplementedException("The id passed is not supported.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();


            foreach (var c in deck.Cards)
            {
                Console.WriteLine("{0} of {1}", c.Name, c.Suit.Name);
            }

            Console.Read();
        }
    }
}

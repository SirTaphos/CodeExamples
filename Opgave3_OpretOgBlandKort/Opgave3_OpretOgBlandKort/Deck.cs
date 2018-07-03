using System;
using System.Collections.Generic;

namespace Opgave3_OpretOgBlandKort
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            var listOfSuits = new List<string> { "Hearts", "Spades", "Diamonds", "Clubs" };
            foreach (var suit in listOfSuits)
            {
                Cards.Add(new Card(suit, "Ace"));
                for (var i = 1; i < 10; i++)
                {
                    Cards.Add(new Card(suit, i.ToString()));
                }
                Cards.Add(new Card(suit, "Knight"));
                Cards.Add(new Card(suit, "Queen"));
                Cards.Add(new Card(suit, "King"));
            }
        }

        public void Shuffle()
        {
            // Create list
            var tmpCards = new List<Card>(52);
            // Populate list to create indexing
            Cards.ForEach(x => tmpCards.Add(x));
            var rnd = new Random();
            foreach (var t in Cards)
            {
                tmpCards.RemoveAt(tmpCards.FindIndex(card => card.Equals(t)));
                tmpCards.Insert(rnd.Next(1, 52), t);
            }
            Cards = tmpCards;
        }
    }
}

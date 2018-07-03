namespace Opgave3_OpretOgBlandKort
{
    public class Card
    {
        public string Suit { get; set; }
        public string Number { get; set; }

        public Card(string suit, string number)
        {
            Suit = suit;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number} of {Suit}";
        }
    }
}

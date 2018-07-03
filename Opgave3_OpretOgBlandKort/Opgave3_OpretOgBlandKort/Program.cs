using System;

namespace Opgave3_OpretOgBlandKort
{
    class Program
    {
        static void Main()
        {
            var deck = new Deck();
            deck.Cards.ForEach(Console.WriteLine);
            Console.ReadLine();
            deck.Shuffle();
            deck.Cards.ForEach(Console.WriteLine);
            Console.ReadLine();
            deck.Shuffle();
            deck.Cards.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}

using System;

namespace Cap08.CardShuffling
{
    public class DeckOfCardTest
    {
        public static void Principal()
        {
            var myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle();

            for (var i = 0; i < 52; i++)
            {
                Console.WriteLine($"{myDeckOfCards.DealCard(),-19}");
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
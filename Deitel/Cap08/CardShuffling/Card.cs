using System;

namespace Cap08.CardShuffling
{
    public class Card
    {
        private string Face { get; }
        private string Suit { get; }

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString() => $"{Face} of {Suit}";
    }
}
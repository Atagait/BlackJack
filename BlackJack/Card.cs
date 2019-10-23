namespace BlackJack {
    public enum Suit
    {
        Hearts,
        Spades,
        Clubs,
        Diamonds

    }
    class Card {
        public Suit Suit { get; }
        public int Value { get; }

        public Card(int value, Suit suit){
            Value = value;
            Suit = suit;
        }

        public override string ToString() =>
            $"{Value} of {Suit}";
    }
}

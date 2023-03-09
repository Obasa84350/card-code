using System;
using System.Collections.Generic;
using System.Text;

public class Card {
    public enum SuitType { Clubs, Diamonds, Hearts, Spades };
    public enum RankType { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    public SuitType Suit { get; private set; }
    public RankType Rank { get; private set; }

    public Card(SuitType suit, RankType rank) {
        this.Suit = suit;
        this.Rank = rank;
    }

    public override string ToString() {
        return $"{Rank} of {Suit}";
    }
}

public class Pack {
    private List<Card> cards;

    public Pack() {
        this.cards = new List<Card>();

        foreach (Card.SuitType suit in Enum.GetValues(typeof(Card.SuitType))) {
            foreach (Card.RankType rank in Enum.GetValues(typeof(Card.RankType))) {
                Card card = new Card(suit, rank);
                this.cards.Add(card);
            }
        }
    }

    public static bool ShuffleCardPack(int typeOfShuffle) {
        // TODO: implement different shuffling algorithms based on typeOfShuffle
        return true;
    }

    public static Card DealCard() {
        // TODO: implement dealing a single card from the pack
        return null;
    }

    public static List<Card> DealCard(int amount) {
        // TODO: implement dealing a specified number of cards from the pack
        return null;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        foreach (Card card in cards) {
            sb.AppendLine(card.ToString());
        }
        return sb.ToString();
    }
}

public class Testing {
    public static void Main(string[] args) {
        Pack pack = new Pack();
        Console.WriteLine("Initial pack:");
        Console.WriteLine(pack.ToString());

        // Shuffle the pack using different algorithms
        Pack.ShuffleCardPack(1); // Fisher-Yates Shuffle
        Console.WriteLine("Shuffled pack (Fisher-Yates Shuffle):");
        Console.WriteLine(pack.ToString());

        Pack.ShuffleCardPack(2); // Riffle Shuffle
        Console.WriteLine("Shuffled pack (Riffle Shuffle):");
        Console.WriteLine(pack.ToString());

        Pack.ShuffleCardPack(3); // No Shuffle
        Console.WriteLine("Shuffled pack (No Shuffle):");
        Console.WriteLine(pack.ToString());

        // Deal a single card
        Card card = Pack.DealCard();
        Console.WriteLine("Dealt card: " + card.ToString());

        // Deal multiple cards
        List<Card> cards = Pack.DealCard(5);
        Console.WriteLine("Dealt cards:");
        foreach (Card c in cards) {
            Console.WriteLine(c.ToString());
        }
    }
}

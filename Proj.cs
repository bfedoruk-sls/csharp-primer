// Blackjack.cs — CAPSTONE: build a game of Blackjack
// ===================================================
//
// Goal: a console Blackjack game. You're dealt two cards; you HIT to draw
// another or STAND to hold. Go over 21 and you bust. After you stand, the
// dealer draws to at least 17. Closest to 21 without busting wins.
//
// Card values: number cards are their number, J/Q/K are 10, and an Ace is 11
// OR 1 — whichever keeps the hand from busting. That Ace rule is the heart of
// this project (every good capstone has one tricky part).
//
// The map from the examples:
//   Console I/O ...................... Ex1  -> ask hit or stand, show the table
//   if / switch ...................... Ex2  -> read the player's choice
//   for / while / break .............. Ex3  -> keep dealing until stand or bust
//   methods & classes ................ Ex4  -> the Card, Deck, and Hand types
//   List<T> .......................... Ex5  -> the deck and each hand
//
// Build it PIECE BY PIECE, running after each piece with:  dotnet run Blackjack.cs
//
// C# wants the runnable code first and the classes below it, so read the game
// loop here, then scroll down to the Card / Deck / Hand definitions.

using System;
using System.Collections.Generic;

Deck deck = new Deck();
Hand player = new Hand();
Hand dealer = new Hand();

// Opening deal: two cards each.
player.Add(deck.Deal());
player.Add(deck.Deal());
dealer.Add(deck.Deal());
dealer.Add(deck.Deal());

Console.WriteLine($"Dealer shows: {dealer.Cards[0]}");
Console.WriteLine($"Your hand: {player}  (total {player.Total()})");

// Player's turn: hit until they stand or go over 21.
while (player.Total() < 21)
{
    Console.Write("Hit or stand? (h/s): ");
    string? choice = Console.ReadLine()?.ToLower();

    if (choice == "h")
    {
        player.Add(deck.Deal());
        Console.WriteLine($"Your hand: {player}  (total {player.Total()})");
    }
    else if (choice == "s")
    {
        break;
    }
    else
    {
        Console.WriteLine("Please type h or s.");
    }
}

// TODO: if player.Total() > 21, print a "bust" message and stop the game here —
//       the dealer doesn't need to play.

// TODO: dealer's turn. While the dealer's total is below 17, deal them another
//       card. Then reveal the dealer's hand and total.

// TODO: decide the winner. Compare the two totals, remembering that going over
//       21 is an automatic loss. Print who won (or a tie).


// ===================== classes (finish the Hand) =====================

// A single playing card. Given to you.
class Card
{
    public string Rank;   // "2".."10", "J", "Q", "K", "A"
    public string Suit;   // "Hearts", "Diamonds", "Clubs", "Spades"

    public Card(string rank, string suit)
    {
        Rank = rank;
        Suit = suit;
    }

    // The value of THIS card on its own. Aces are 11 here; the Hand decides
    // when to drop them to 1.
    public int Value()
    {
        if (Rank == "A") return 11;
        if (Rank == "K" || Rank == "Q" || Rank == "J") return 10;
        return int.Parse(Rank);   // "2".."10" -> 2..10
    }

    // How the card prints, e.g. "Q of Spades".
    public override string ToString() => $"{Rank} of {Suit}";
}

// A 52-card deck you can deal from. Given to you.
class Deck
{
    private List<Card> cards = new List<Card>();
    private Random rng = new Random();

    public Deck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        foreach (string suit in suits)
            foreach (string rank in ranks)
                cards.Add(new Card(rank, suit));
    }

    // Take one random card out of the deck and return it.
    public Card Deal()
    {
        int i = rng.Next(cards.Count);   // a random position, 0..Count-1
        Card picked = cards[i];
        cards.RemoveAt(i);
        return picked;
    }
}

// The cards a player is holding. YOU finish Total().
class Hand
{
    public List<Card> Cards = new List<Card>();

    public void Add(Card card)
    {
        Cards.Add(card);
    }

    // TODO: return the best Blackjack total for this hand.
    //   1. Add up every card's Value() (aces count 11 for now).
    //   2. Count how many aces are in the hand (loop over Cards, check
    //      Rank == "A").
    //   3. While the total is over 21 AND there's still an ace counted as 11,
    //      subtract 10 (that turns one ace from 11 into 1) and use up one ace.
    public int Total()
    {
        // TODO: implement the ace-aware total described above.
        return 0;
    }

    // Prints the hand as "5 of Hearts, K of Clubs".
    public override string ToString()
    {
        return string.Join(", ", Cards);
    }
}
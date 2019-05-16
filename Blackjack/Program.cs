using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            string[] color = {"pik", "kier", "karo", "trefl" };
            string[] name = {" 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", " 10", " Jack", " Queen", " King", " As"};
            int[] power = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //Creating cards color
            Colors colors = new Colors(color, name);

            //Adding power to cards
            for (int i = 0; i < colors.CardColor().Count; i++)
            {
                utilities.Power(colors.CardColor()[i]);
            }

            //Creating cards
            List<Card> cards = new List<Card>();
            for (int i = 0; i < colors.CardColor().Count; i++)
            {
                cards.Add(new Card(colors.CardColor()[i], utilities.Power(colors.CardColor()[i])));
            }

            //Adding cards to deck
            Deck deck = new Deck(cards);

            //Shuffle deck
            deck.ShuffleDeck();
            Console.WriteLine("Cards has been shuffled.");

            //Game
            Board board = new Board();
            board.Start(deck);
        }
    }
}

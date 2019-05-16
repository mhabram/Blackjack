using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Board
    {
        public void Start(Deck deck)
        {
            int score = 0;
            for (int i = 0; i < deck.CardDeck.Count; i++)
            {
                Console.WriteLine("Pull a card. (Yes/No)");
                string play = Console.ReadLine();
                if (play.ToLower() == "yes" || play.ToLower() == "y")
                {
                    score += deck.GetCard(i).Power;
                    Console.WriteLine($"Your card is: {deck.GetCard(i)}");
                    Console.WriteLine($"Your score is: {score}");
                }
                else
                {
                    Console.WriteLine($"You have ended game with score: {score}");
                    break;
                }

                if (!CheckPower(score))
                {
                    Console.WriteLine("Game Over you have more than 21 score!");
                    break;
                }
            }
        }

        public bool CheckPower(int score)
        {
            if (score > 21)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

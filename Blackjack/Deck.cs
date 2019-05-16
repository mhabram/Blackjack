using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Deck
    {
        List<Card> cardDeck;

        public Deck(List<Card> cardDeck)
        {
            this.cardDeck = cardDeck;
        }

        public List<Card> CardDeck
        {
            get { return this.cardDeck; }
        }

        public void Show()     
        {
            foreach (Object obj in cardDeck)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();
            int rng = 0;
            Card temp = new Card();
            for (int i = 0; i < cardDeck.Count; i++)
            {
                rng = rand.Next(0, cardDeck.Count);
                temp = cardDeck[i];
                cardDeck[i] = cardDeck[rng];
                cardDeck[rng] = temp;
            }
        }

        public Card GetCard(int index)
        {
            return cardDeck[index];
        }
    }
}


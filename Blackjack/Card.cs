using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Card
    {
        string color;
        int power;
        
        public Card()
        {

        }

        public Card (string color, int power)
        {
            this.color = color;
            this.power = power;
        }

        public int Power
        {
            get { return this.power; }
        }

        public override string ToString()
        {
            return string.Format($"Color: {color}, Power: {power}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Colors
    {
        string[] color;
        string[] name;

        public Colors(string[] color, string[] name)
        {
            this.color = color;
            this.name = name;
        }

        public List<string> CardColor()
        {
            List<string> cardName = new List<string>();
            for (int i = 0; i < color.Length; i++)
            {
                for (int j = 0; j < name.Length; j++)
                {
                    cardName.Add(color[i] + name[j]);
                }
            }
            return cardName;
        }
    }
}

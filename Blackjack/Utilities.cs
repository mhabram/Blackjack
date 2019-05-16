using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Utilities
    {
        Dictionary<string, int> givePower = new Dictionary<string, int>();

        public Utilities ()
        {
            givePower.Add("2", 2);
            givePower.Add("3", 3);
            givePower.Add("4", 4);
            givePower.Add("5", 5);
            givePower.Add("6", 6);
            givePower.Add("7", 7);
            givePower.Add("8", 8);
            givePower.Add("9", 9);
            givePower.Add("10", 10);
            givePower.Add("Jack", 2);
            givePower.Add("Queen", 3);
            givePower.Add("King", 4);
            givePower.Add("As", 11);
        }

        public int Power(string name)
        {
            string[] temp = name.Split(" ");
            return givePower[temp[1]];
        }
    }
}

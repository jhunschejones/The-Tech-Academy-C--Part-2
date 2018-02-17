using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardWar
{
    public class Card
    {
        public string Suit { get; set; }
        public string Kind { get; set; }

        public int CardValue()
        {
            int value = 0;

            if (this.Kind == "Jack")
                value = 11;
            else if (this.Kind == "Queen")
                value = 12;
            else if (this.Kind == "King")
                value = 13;
            else if (this.Kind == "Ace")
                value = 14;
            else
                value = int.Parse(this.Kind);

            return value;
        }
    }
}
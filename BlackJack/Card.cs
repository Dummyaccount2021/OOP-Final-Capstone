using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Card
    {   
        private string _suit;
        private int _value;
        private string _face;

        public Card()
        {
            //constructor
        }
        public bool setSuit(string input)
        {
            //set values for suits
        }

        public string getSuit()
        {
            //return value of suit
        }

        public void setValue(string input)
        {
            //set values numeric value of a specific card 
        }

        public string getValue()
        {
            //return numeric value of card as a string 
        }

        public void setFace(string input)
        {
            //set face value of card
        }

        public string getFace()
        {
            //return face value of card as a string
        }
    }
}
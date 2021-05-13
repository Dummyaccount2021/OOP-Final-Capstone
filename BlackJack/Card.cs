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
            switch (input)
            {
                case "diamonds":
                    _suit = input;
                    return true;

                case "heart":
                    _suit = input;
                    return true;

                case "spade":
                    _suit = input;
                    return true;

                case "clubs":
                    _suit = input;
                    return true;

                default:
                    return false;
            }

        }

        public string getSuit()
        {
            return _suit;
        }

        public bool setValue(string input)
        {
           if(int.TryParse(input, out _))
           {
                switch (input)
                {
                    case "2":
                        _value = int.Parse(input);
                        return true;

                    case "3":
                        _value = int.Parse(input);
                        return true;

                    case "4":
                        _value = int.Parse(input);
                        return true;

                    case "5":
                        _value = int.Parse(input);
                        return true;

                    case "6":
                        _value = int.Parse(input);
                        return true;

                    case "7":
                        _value = int.Parse(input);
                        return true;

                    case "8":
                        _value = int.Parse(input);
                        return true;

                    case "9":
                        _value = int.Parse(input);
                        return true;

                    default:
                        return false;
                }
           }
            return false;
        }

        public string getValue()
        {
            return _value.ToString();
        }

        public bool setFace(string input)
        {
            
            switch (input)
            {

                case "ace":
                    _face = input;
                    return true;

                case "jack":
                    _face = input;
                    return true;

                case "queen":
                    _face = input;
                    return true;

                case "king":
                    _face = input;
                    return true;

                case "joker":
                    _face = input;
                    return true;

                default:
                    return false;
            }

        }

        public string getFace()
        {
            return _face;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisualApplication
{


    class Card
    {
        public int CardID { get; private set; } // Card Identificator
        public string CardNumber { get; private set; }  //16-digit card number
        public string CardPassword { get; private set; } //card pin code
        public CardStatus Status { get; private set; }

        public Card() { }
        public Card(int id, string number, string pin)
        {
            CardID = id;
            CardNumber = number;
            CardPassword = pin;
        }

        public enum CardStatus : byte
        {
            Blocked,
            Active,
            NoActivated
        };

    }
}

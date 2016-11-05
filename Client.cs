using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisualApplication
{
    class Client
    {
        public int ClientID { get; private set; }
        public string ClientFirstName { get; private set; }
        public string ClientFatherName { get; private set; }
        public string ClientSurName { get; private set; }
        public double ClientMoney { get; private set; }
        public Card ClientCard { get; private set; }

        public Client() { }

        public Client(int id, string fName, string frName, string sName, float money, Card card)
        {
            ClientID = id;
            ClientFirstName = fName;
            ClientFatherName = frName;
            ClientSurName = sName;
            ClientMoney = money;
            ClientCard = card;
        }


    }
}

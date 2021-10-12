using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Card
{
    class Client
    {
        public void GetCard()
        {
            //Produce Card from Card Factory.
            Console.WriteLine("");
            Console.WriteLine("Cards: ");
            Console.WriteLine("---------------------------------------------------------------------");
            var debitCardFactory = new CardFactory("Visa");
            Console.WriteLine(debitCardFactory.CreateCard("DebitCard").Result());
            Console.WriteLine(debitCardFactory.CreateCard("CreditCard").Result());            
        }
    }
}

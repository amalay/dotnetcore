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
            var factory = new CardFactory("Visa");
            Console.WriteLine(factory.CreateCard("DebitCard").Result());
            Console.WriteLine(factory.CreateCard("CreditCard").Result());            
        }
    }
}

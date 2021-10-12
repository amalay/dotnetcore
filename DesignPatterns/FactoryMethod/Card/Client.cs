using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Card
{
    class Client
    {
        public void GetCard()
        {
            //Produce Feature Phone from Feature Phone Factory.
            Console.WriteLine("");
            Console.WriteLine("Debit Cards: ");
            Console.WriteLine("---------------------------------------------------------------------");
            AbstractCardFactory debitCardFactory = new DebitCardFactory("Visa");
            Console.WriteLine(debitCardFactory.CreateCard().Result());

            //Produce Smart Phone from Smart Phone Factory.
            Console.WriteLine("");
            Console.WriteLine("Credit Cards: ");
            Console.WriteLine("---------------------------------------------------------------------");
            AbstractCardFactory creditCardFactory = new CreditCardFactory("Master");
            Console.WriteLine(creditCardFactory.CreateCard().Result());
        }
    }
}

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
            //Produce Debit Cards from Debit Card Factory.            
            Console.WriteLine("Debit Cards: ");
            Console.WriteLine("----------------------------");   
            
            AbstractCardFactory debitCardFactory = new DebitCardFactory();
            AbstractCard visaDebitCard = debitCardFactory.CreateCard(CardName.Gold, CardBrand.Visa);

            if (visaDebitCard != null)
            {
                Console.WriteLine($"{visaDebitCard.Name} {visaDebitCard.Type} by {visaDebitCard.Brand}");
            }

            //Produce Credit Cards from Credit Card Factory.
            Console.WriteLine("");
            Console.WriteLine("Credit Cards: ");
            Console.WriteLine("----------------------------");

            AbstractCardFactory creditCardFactory = new CreditCardFactory();
            AbstractCard visaCreditCard = creditCardFactory.CreateCard(CardName.Platinum, CardBrand.Visa);

            if (visaCreditCard != null)
            {
                Console.WriteLine($"{visaCreditCard.Name} {visaCreditCard.Type} by {visaCreditCard.Brand}");
            }

            Console.WriteLine("");
        }
    }
}

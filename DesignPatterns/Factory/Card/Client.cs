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
            //Produce Cards from Card Factory.            
            Console.WriteLine("Visa Cards: ");
            Console.WriteLine("----------------------------");
            var factory = new CardFactory();
            var visaDebitCard = factory.CreateCard(CardName.Platinum, CardBrand.Visa, CardType.DebitCard);
            var visaCreditCard = factory.CreateCard(CardName.Platinum, CardBrand.Visa, CardType.CreditCard);

            if (visaDebitCard != null)
            {
                Console.WriteLine($"{visaDebitCard.Name} {visaDebitCard.Type} by {visaDebitCard.Brand}");
            }

            if (visaCreditCard != null)
            {
                Console.WriteLine($"{visaCreditCard.Name} {visaCreditCard.Type} by {visaCreditCard.Brand}");
            }

            Console.WriteLine("");
            Console.WriteLine("Master Cards: ");
            Console.WriteLine("----------------------------");            
            var masterDebitCard = factory.CreateCard(CardName.Platinum, CardBrand.Master, CardType.DebitCard);
            var masterCreditCard = factory.CreateCard(CardName.Platinum, CardBrand.Master, CardType.CreditCard);

            if (masterDebitCard != null)
            {
                Console.WriteLine($"{masterDebitCard.Name} {masterDebitCard.Type} by {masterDebitCard.Brand}");
            }

            if (masterCreditCard != null)
            {
                Console.WriteLine($"{masterCreditCard.Name} {masterCreditCard.Type} by {masterCreditCard.Brand}");
            }
        }
    }
}

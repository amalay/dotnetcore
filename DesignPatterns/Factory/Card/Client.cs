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

            CardFactory factory = new CardFactory();
            AbstractCard visaDebitCard = factory.CreateCard(CardName.Platinum, CardBrand.Visa, CardType.DebitCard);
            AbstractCard visaCreditCard = factory.CreateCard(CardName.Platinum, CardBrand.Visa, CardType.CreditCard);

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

            AbstractCard masterDebitCard = factory.CreateCard(CardName.Platinum, CardBrand.Master, CardType.DebitCard);
            AbstractCard masterCreditCard = factory.CreateCard(CardName.Platinum, CardBrand.Master, CardType.CreditCard);

            if (masterDebitCard != null)
            {
                Console.WriteLine($"{masterDebitCard.Name} {masterDebitCard.Type} by {masterDebitCard.Brand}");
            }

            if (masterCreditCard != null)
            {
                Console.WriteLine($"{masterCreditCard.Name} {masterCreditCard.Type} by {masterCreditCard.Brand}");
            }

            Console.WriteLine("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Card
{
    class Client
    {
        public void GetCard()
        {
            //Produce Visa family products from Visa Card Factory.            
            Console.WriteLine("Visa Family Products: ");
            Console.WriteLine("----------------------------");

            AbstractCardFactory visaCardFactory = new VisaCardFactory();
            AbstractCard visaDebitCard = visaCardFactory.CreateDebitCard(CardName.Gold);
            AbstractCard visaCreditCard = visaCardFactory.CreateCreditCard(CardName.Gold);

            if (visaDebitCard != null)
            {
                Console.WriteLine($"{visaDebitCard.Name} {visaDebitCard.Type} by {visaDebitCard.Brand}");
            }

            if (visaCreditCard != null)
            {
                Console.WriteLine($"{visaCreditCard.Name} {visaCreditCard.Type} by {visaCreditCard.Brand}");
            }

            //Produce Master family products from Master Card Factory.            
            Console.WriteLine("");
            Console.WriteLine("Master Family Products: ");
            Console.WriteLine("----------------------------");

            AbstractCardFactory masterCardFactory = new MasterCardFactory();
            AbstractCard masterDebitCard = masterCardFactory.CreateDebitCard(CardName.Platinum);
            AbstractCard masterCreditCard = masterCardFactory.CreateCreditCard(CardName.Platinum);

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

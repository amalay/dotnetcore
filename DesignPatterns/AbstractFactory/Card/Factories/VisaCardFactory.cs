using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Card
{
    class VisaCardFactory : AbstractCardFactory
    {
        public override AbstractCard CreateCreditCard(string name)
        {
            return new CreditCard(name, CardBrand.Visa);
        }

        public override AbstractCard CreateDebitCard(string name)
        {
            return new DebitCard(name, CardBrand.Visa);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Card
{
    class CreditCardFactory : AbstractCardFactory
    {
        public override AbstractCard CreateCard(string name, string brand)
        {
            return new CreditCard(name, brand);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Card
{
    class CreditCardFactory : AbstractCardFactory
    {
        private readonly string _name;

        public CreditCardFactory(string name)
        {
            this._name = name;
        }

        public override AbstractCard CreateCard()
        {
            return new CreditCard(this._name);
        }
    }
}

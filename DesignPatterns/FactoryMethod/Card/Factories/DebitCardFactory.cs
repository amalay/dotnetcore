using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Card
{
    class DebitCardFactory : AbstractCardFactory
    {
        private readonly string _name;

        public DebitCardFactory(string name)
        {
            this._name = name;
        }

        public override AbstractCard CreateCard()
        {
            return new DebitCard(this._name);
        }
    }
}

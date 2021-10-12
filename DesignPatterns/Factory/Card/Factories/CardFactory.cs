using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Card
{
    class CardFactory
    {
        private readonly string _name;

        public CardFactory(string name)
        {
            this._name = name;
        }

        public AbstractCard CreateCard(string type)
        {
            switch (type)
            {
                case "DebitCard":
                    return new DebitCard(this._name);

                case "CreditCard":
                    return new CreditCard(this._name);

                default:
                    throw new NotSupportedException();
            }
        }
    }
}

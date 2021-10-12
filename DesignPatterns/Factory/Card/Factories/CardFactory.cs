using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Card
{
    class CardFactory
    {
        public AbstractCard CreateCard(string name, string brand, string type)
        {
            switch (type)
            {
                case CardType.DebitCard:
                    return new DebitCard(name, brand);

                case CardType.CreditCard:
                    return new CreditCard(name, brand);

                default:
                    throw new NotSupportedException();
            }
        }
    }
}

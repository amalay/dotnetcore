using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Card
{
    class MasterCardFactory : AbstractCardFactory
    {
        public override AbstractCard CreateCreditCard(string name)
        {
            return new CreditCard(name, CardBrand.Master);
        }

        public override AbstractCard CreateDebitCard(string name)
        {
            return new DebitCard(name, CardBrand.Master);
        }
    }
}

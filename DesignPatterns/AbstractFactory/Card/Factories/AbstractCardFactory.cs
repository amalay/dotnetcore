using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Card
{
    abstract class AbstractCardFactory
    {
        public abstract AbstractCard CreateCreditCard(string name);

        public abstract AbstractCard CreateDebitCard(string name);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Card
{
    abstract class AbstractCardFactory
    {
        public abstract AbstractCard CreateCard(string name, string brand);
    }
}

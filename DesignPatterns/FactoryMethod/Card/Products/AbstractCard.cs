using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Card
{
    abstract class AbstractCard
    {
        public abstract string Name { get; }

        public abstract string Result();
    }
}

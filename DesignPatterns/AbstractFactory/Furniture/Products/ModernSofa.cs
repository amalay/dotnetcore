using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Furniture
{
    class ModernSofa : AbstractSofa
    {
        public override string Result()
        {
            return "Modern Sofa";
        }

        public override string Result(AbstractChair chair)
        {
            return this.GetType().Name + " with " + chair.GetType().Name;
        }
    }
}

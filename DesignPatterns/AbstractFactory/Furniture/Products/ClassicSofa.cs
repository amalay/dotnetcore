using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Furniture
{
    class ClassicSofa : AbstractSofa
    {
        public override string Result()
        {
            return "Classic Sofa";
        }

        public override string Result(AbstractChair chair)
        {
            return this.GetType().Name + " with " + chair.GetType().Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Furniture
{
    class ModernFactory : AbstractFurnitureFactory
    {
        public override AbstractChair CreateChair()
        {
            return new ModernChair();
        }

        public override AbstractSofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}

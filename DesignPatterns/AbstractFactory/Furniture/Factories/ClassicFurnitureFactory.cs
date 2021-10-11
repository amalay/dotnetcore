using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Furniture
{
    class ClassicFurnitureFactory : AbstractFurnitureFactory
    {
        public override AbstractChair CreateChair()
        {
            return new ClassicChair();
        }

        public override AbstractSofa CreateSofa()
        {
            return new ClassicSofa();
        }
    }
}

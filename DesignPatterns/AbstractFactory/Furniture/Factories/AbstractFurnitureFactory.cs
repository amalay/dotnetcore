using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Furniture
{
    abstract class AbstractFurnitureFactory
    {
        public abstract AbstractChair CreateChair();

        public abstract AbstractSofa CreateSofa();
    }    
}

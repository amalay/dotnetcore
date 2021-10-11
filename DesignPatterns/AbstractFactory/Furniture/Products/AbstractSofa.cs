using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Furniture
{
    abstract class AbstractSofa
    {
        public abstract string Result();

        public abstract string Result(AbstractChair chair);
    }    
}

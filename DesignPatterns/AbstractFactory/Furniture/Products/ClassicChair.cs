using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Furniture
{
    class ClassicChair : AbstractChair
    {
        public override string Result()
        {
            return "Classic Chair";
        }
    }
}

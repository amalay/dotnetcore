using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Vehicle
{
    class HondaShine : IBike
    {
        public string Result()
        {
            return "Honda Shine";
        }
    }
}

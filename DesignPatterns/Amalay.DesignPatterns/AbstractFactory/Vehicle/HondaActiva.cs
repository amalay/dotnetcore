using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Vehicle
{
    class HondaActiva : IScooter
    {
        public string Result()
        {
            return "Honda Activa";
        }
    }
}

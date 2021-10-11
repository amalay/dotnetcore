using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class SamsungGalaxy : ISmartPhone
    {
        public string Result()
        {
            return "Samsung Galaxy";
        }
    }
}

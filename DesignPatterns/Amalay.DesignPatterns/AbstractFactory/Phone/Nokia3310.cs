using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class Nokia3310 : IFeaturePhone
    {
        public string Result()
        {
            return "Nokia 3310";
        }
    }
}

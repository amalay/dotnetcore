using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class NokiaFactory : IPhoneFactory
    {
        public IFeaturePhone CreateFeaturePhone()
        {
            return new Nokia3310();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}

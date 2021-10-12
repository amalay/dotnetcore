using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class NokiaFactory : IPhoneFactory
    {
        public IPhone CreateFeaturePhone(string name)
        {
            return new FeaturePhone(name, PhoneBrand.Nokia);
        }

        public IPhone CreateSmartPhone(string name)
        {
            return new SmartPhone(name, PhoneBrand.Nokia);
        }
    }
}

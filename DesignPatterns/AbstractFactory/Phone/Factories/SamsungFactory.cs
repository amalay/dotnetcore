using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class SamsungFactory : IPhoneFactory
    {
        public IPhone CreateFeaturePhone(string name)
        {
            return new FeaturePhone(name, PhoneBrand.Samsung);
        }

        public IPhone CreateSmartPhone(string name)
        {
            return new SmartPhone(name, PhoneBrand.Samsung);
        }
    }
}

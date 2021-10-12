using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Phone
{
    class PhoneFactory
    {
        public IPhone CreateFeaturePhone(string name, string brand)
        {
            return new FeaturePhone(name, brand);
        }

        public IPhone CreateSmartPhone(string name, string brand)
        {
            return new SmartPhone(name, brand);
        }
    }
}

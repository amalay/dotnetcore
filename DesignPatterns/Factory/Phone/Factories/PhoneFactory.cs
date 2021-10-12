using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Phone
{
    class PhoneFactory
    {
        public IPhone CreateFeaturePhone()
        {
            return new FeaturePhone();
        }

        public IPhone CreateSmartPhone()
        {
            return new SmartPhone();
        }
    }
}

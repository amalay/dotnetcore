using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class SamsungFactory : IPhoneFactory
    {
        public IFeaturePhone CreateFeaturePhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}

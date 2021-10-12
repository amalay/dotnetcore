using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Phone
{
    class FeaturePhoneFactory : IPhoneFactory
    {
        public IPhone CreatePhone(string name, string brand)
        {
            return new FeaturePhone(name, brand);
        }
    }
}

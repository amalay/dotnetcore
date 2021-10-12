using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Phone
{
    class FeaturePhoneFactory : IPhoneFactory
    {
        public IPhone CreatePhone()
        {
            return new FeaturePhone();
        }
    }
}

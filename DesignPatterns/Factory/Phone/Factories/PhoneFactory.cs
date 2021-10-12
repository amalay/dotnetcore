using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Phone
{
    class PhoneFactory
    {
        public IPhone CreatePhone(string type)
        {
            switch (type)
            {
                case "FeaturePhone":
                    return new FeaturePhone();

                case "SmartPhone":
                    return new SmartPhone();

                default:
                    throw new NotSupportedException();
            }
        }
    }
}

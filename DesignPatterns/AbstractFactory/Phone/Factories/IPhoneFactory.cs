using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    public interface IPhoneFactory
    {
        IPhone CreateFeaturePhone(string name);

        IPhone CreateSmartPhone(string name);
    }    
}

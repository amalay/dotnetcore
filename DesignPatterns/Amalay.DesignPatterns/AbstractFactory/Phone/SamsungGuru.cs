using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class SamsungGuru : IFeaturePhone
    {
        public string Result()
        {
            return "Samsung Guru";
        }
    }
}

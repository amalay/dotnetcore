using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Phone
{
    class FeaturePhone : IPhone
    {
        private readonly string _name;
        private readonly string _type;
        private readonly string _brand;

        public FeaturePhone(string name, string brand)
        {
            this._name = name;
            this._type = PhoneType.FeaturePhone;
            this._brand = brand;
        }

        public string Name => this._name;

        public string Type => this._type;

        public string Brand => this._brand;
    }
}

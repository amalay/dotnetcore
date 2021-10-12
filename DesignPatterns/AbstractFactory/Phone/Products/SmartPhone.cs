using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class SmartPhone : IPhone
    {
        private readonly string _name;
        private readonly string _type;
        private readonly string _brand;

        public SmartPhone(string name, string brand)
        {
            this._name = name;
            this._type = PhoneType.SmartPhone;
            this._brand = brand;
        }

        public string Name => this._name;

        public string Type => this._type;

        public string Brand => this._brand;
    }
}

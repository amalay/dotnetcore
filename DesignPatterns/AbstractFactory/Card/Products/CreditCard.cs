using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Card
{
    class CreditCard : AbstractCard
    {
        private readonly string _name;
        private readonly string _type;
        private readonly string _brand;

        public CreditCard(string name, string brand)
        {
            this._name = name;
            this._type = CardType.CreditCard;
            this._brand = brand;
        }

        public override string Name
        {
            get
            {
                return this._name;
            }
        }

        public override string Type
        {
            get
            {
                return this._type;
            }
        }

        public override string Brand
        {
            get
            {
                return this._brand;
            }
        }
    }
}

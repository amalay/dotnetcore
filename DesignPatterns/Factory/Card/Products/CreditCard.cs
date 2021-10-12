using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Card
{
    class CreditCard : AbstractCard
    {
        private readonly string _name;

        public CreditCard(string name)
        {
            this._name = name;
        }

        public override string Name
        {
            get
            {
                return this._name;
            }
        }

        public override string Result()
        {
            return $"{this.Name} Credit Card";
        }
    }
}

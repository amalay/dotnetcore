using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    public interface IPhone
    {
        public string Name { get; }

        public string Type { get; }

        public string Brand { get; }
    }
}

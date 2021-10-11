using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class NokiaPixel : ISmartPhone
    {
        public string Result()
        {
            return "Nokia Pixel";
        }
    }
}

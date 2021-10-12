using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Phone
{
    class Client
    {
        public void GetPhone()
        {
            //Produce Card from Card Factory.
            Console.WriteLine("");
            Console.WriteLine("Phones: ");
            Console.WriteLine("---------------------------------------------------------------------");
            var factory = new PhoneFactory();
            Console.WriteLine(factory.CreateFeaturePhone().Result());
            Console.WriteLine(factory.CreateSmartPhone().Result());
        }
    }
}

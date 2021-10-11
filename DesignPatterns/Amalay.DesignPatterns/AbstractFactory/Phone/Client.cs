using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Phone
{
    class Client
    {
        public void GetPhone()
        {
            //Produce Nokia family products from Nokia factory.
            Console.WriteLine("");
            Console.WriteLine("Nokia Family Products: ");
            Console.WriteLine("---------------------------------------------------------------------");
            IPhoneFactory nokiaFactory = new NokiaFactory();
            Console.WriteLine(nokiaFactory.CreateFeaturePhone().Result());
            Console.WriteLine(nokiaFactory.CreateSmartPhone().Result());

            //Produce Samsung family products from Samsung factory.
            Console.WriteLine("");
            Console.WriteLine("Samsung Family Products: ");
            Console.WriteLine("---------------------------------------------------------------------");
            IPhoneFactory samsungFactory = new SamsungFactory();
            Console.WriteLine(samsungFactory.CreateFeaturePhone().Result());
            Console.WriteLine(samsungFactory.CreateSmartPhone().Result());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.FactoryMethod.Phone
{
    class Client
    {
        public void GetPhone()
        {
            //Produce Feature Phone from Feature Phone Factory.
            Console.WriteLine("");
            Console.WriteLine("Feature Phones: ");
            Console.WriteLine("---------------------------------------------------------------------");
            IPhoneFactory featurePhoneFactory = new FeaturePhoneFactory();
            Console.WriteLine(featurePhoneFactory.CreatePhone().Result());            

            //Produce Smart Phone from Smart Phone Factory.
            Console.WriteLine("");
            Console.WriteLine("Smart Phones: ");
            Console.WriteLine("---------------------------------------------------------------------");
            IPhoneFactory smartPhoneFactory = new SmartPhoneFactory();
            Console.WriteLine(smartPhoneFactory.CreatePhone().Result());
        }
    }
}

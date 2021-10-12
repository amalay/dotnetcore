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
            Console.WriteLine("Feature Phones: ");
            Console.WriteLine("----------------------------");

            IPhoneFactory featurePhoneFactory = new FeaturePhoneFactory();
            IPhone featurePhone = featurePhoneFactory.CreatePhone(PhoneName.Nokia3310, PhoneBrand.Nokia);

            if (featurePhone != null)
            {
                Console.WriteLine($"{featurePhone.Name} {featurePhone.Type} by {featurePhone.Brand}");
            }

            //Produce Smart Phone from Smart Phone Factory.
            Console.WriteLine("");
            Console.WriteLine("Smart Phones: ");
            Console.WriteLine("----------------------------");

            IPhoneFactory smartPhoneFactory = new SmartPhoneFactory();
            IPhone smartPhone = smartPhoneFactory.CreatePhone(PhoneName.NokiaPixel, PhoneBrand.Nokia);
            
            if (smartPhone != null)
            {
                Console.WriteLine($"{smartPhone.Name} {smartPhone.Type} by {smartPhone.Brand}");
            }

            Console.WriteLine("");
        }
    }
}

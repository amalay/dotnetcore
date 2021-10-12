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
            //Produce Phones from Phone Factory.            
            Console.WriteLine("Nokia Phones: ");
            Console.WriteLine("----------------------------");
            var factory = new PhoneFactory();
            var nokiaFeaturePhone = factory.CreateFeaturePhone(PhoneName.Nokia3310, PhoneBrand.Nokia);
            var nokiaSmartPhone = factory.CreateSmartPhone(PhoneName.NokiaPixel, PhoneBrand.Nokia);

            if (nokiaFeaturePhone != null)
            {
                Console.WriteLine($"{nokiaFeaturePhone.Name} {nokiaFeaturePhone.Type} by {nokiaFeaturePhone.Brand}");
            }

            if (nokiaSmartPhone != null)
            {
                Console.WriteLine($"{nokiaSmartPhone.Name} {nokiaSmartPhone.Type} by {nokiaSmartPhone.Brand}");
            }

            Console.WriteLine("");
            Console.WriteLine("Samsung Phones: ");
            Console.WriteLine("----------------------------");            
            var samsungFeaturePhone = factory.CreateFeaturePhone(PhoneName.SamsungGuru, PhoneBrand.Samsung);
            var samsungSmartPhone = factory.CreateSmartPhone(PhoneName.SamsungGalaxy, PhoneBrand.Samsung);

            if (samsungFeaturePhone != null)
            {
                Console.WriteLine($"{samsungFeaturePhone.Name} {samsungFeaturePhone.Type} by {samsungFeaturePhone.Brand}");
            }

            if (samsungSmartPhone != null)
            {
                Console.WriteLine($"{samsungSmartPhone.Name} {samsungSmartPhone.Type} by {samsungSmartPhone.Brand}");
            }
        }
    }
}

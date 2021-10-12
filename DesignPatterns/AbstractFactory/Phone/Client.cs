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
            //Produce Nokia family products from Nokia Phone Factory.            
            Console.WriteLine("Nokia Family Products: ");
            Console.WriteLine("----------------------------");

            IPhoneFactory nokiaPhoneFactory = new NokiaFactory();
            IPhone nokiaFeaturePhone = nokiaPhoneFactory.CreateFeaturePhone(PhoneName.Nokia3310);
            IPhone nokiaSmartPhone = nokiaPhoneFactory.CreateSmartPhone(PhoneName.NokiaPixel);

            if (nokiaFeaturePhone != null)
            {
                Console.WriteLine($"{nokiaFeaturePhone.Name} {nokiaFeaturePhone.Type} by {nokiaFeaturePhone.Brand}");
            }

            if (nokiaSmartPhone != null)
            {
                Console.WriteLine($"{nokiaSmartPhone.Name} {nokiaSmartPhone.Type} by {nokiaSmartPhone.Brand}");
            }

            //Produce Samsung family products from Samsung Phone Factory.            
            Console.WriteLine("");
            Console.WriteLine("Samsung Family Products: ");
            Console.WriteLine("----------------------------");

            IPhoneFactory samsungPhoneFactory = new SamsungFactory();
            IPhone samsungFeaturePhone = samsungPhoneFactory.CreateFeaturePhone(PhoneName.SamsungGuru);
            IPhone samsungSmartPhone = samsungPhoneFactory.CreateSmartPhone(PhoneName.SamsungGalaxy);

            if (samsungFeaturePhone != null)
            {
                Console.WriteLine($"{samsungFeaturePhone.Name} {samsungFeaturePhone.Type} by {samsungFeaturePhone.Brand}");
            }

            if (samsungSmartPhone != null)
            {
                Console.WriteLine($"{samsungSmartPhone.Name} {samsungSmartPhone.Type} by {samsungSmartPhone.Brand}");
            }

            Console.WriteLine("");
        }
    }
}

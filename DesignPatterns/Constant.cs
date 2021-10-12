using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns
{
    public partial class Constant
    {
        public const string Select = "---------- Select ----------";
        public const string TestData = "Test Data!";
    }

    public struct CardType
    {
        public const string DebitCard = "Debit Card";
        public const string CreditCard = "Credit Card";
    }

    public struct CardBrand
    {
        public const string Visa = "Visa";
        public const string Master = "Master";
    }

    public struct CardName
    {        
        public const string Silver = "Silver";
        public const string Gold = "Gold";
        public const string Platinum = "Platinum";
    }

    public struct PhoneType
    {
        public const string FeaturePhone = "Feature Phone";
        public const string SmartPhone = "Smart Phone";
    }

    public struct PhoneBrand
    {
        public const string Nokia = "Nokia";
        public const string Samsung = "Samsung";
    }

    public struct PhoneName
    {
        public const string Nokia3310 = "Nokia 3310";
        public const string NokiaPixel = "Nokia Pixel";

        public const string SamsungGuru = "Samsung Guru";
        public const string SamsungGalaxy = "Samsung Galaxy";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Vehicle
{
    class Client
    {
        public void GetVehicle()
        {
            //Produce Honda family products from Honda Vehicle Factory.            
            Console.WriteLine("Honda Family Products: ");
            Console.WriteLine("----------------------------");

            IVehicleFactory hondaVehicleFactory = new HondaFactory();
            ICar hondaCar = hondaVehicleFactory.CreateCar(VehicleName.HondaCity);
            IBike hondaBike = hondaVehicleFactory.CreateBike(VehicleName.HondaShine);
            IScooter hondaScooter = hondaVehicleFactory.CreateScooter(VehicleName.HondaActiva);

            if (hondaCar != null)
            {
                Console.WriteLine($"{hondaCar.Name} {hondaCar.Type} by {hondaCar.Brand}");
            }

            if (hondaBike != null)
            {
                Console.WriteLine($"{hondaBike.Name} {hondaBike.Type} by {hondaBike.Brand}");
            }

            if (hondaScooter != null)
            {
                Console.WriteLine($"{hondaScooter.Name} {hondaScooter.Type} by {hondaScooter.Brand}");
            }

            //Produce Maruti Suzuki family products from Maruti Suzuki Vehicle Factory.            
            Console.WriteLine("");
            Console.WriteLine("Maruti Suzuki Family Products: ");
            Console.WriteLine("----------------------------");

            IVehicleFactory marutiVehicleFactory = new MarutiFactory();
            ICar marutiCar = marutiVehicleFactory.CreateCar(VehicleName.MarutiSuzukiBreza);
            IBike marutiBike = marutiVehicleFactory.CreateBike(VehicleName.MarutiSuzukiGixxer);
            IScooter marutiScooter = marutiVehicleFactory.CreateScooter(VehicleName.MarutiSuzukiAccess125);

            if (marutiCar != null)
            {
                Console.WriteLine($"{marutiCar.Name} {marutiCar.Type} by {marutiCar.Brand}");
            }

            if (marutiBike != null)
            {
                Console.WriteLine($"{marutiBike.Name} {marutiBike.Type} by {marutiBike.Brand}");
            }

            if (marutiScooter != null)
            {
                Console.WriteLine($"{marutiScooter.Name} {marutiScooter.Type} by {marutiScooter.Brand}");
            }

            Console.WriteLine("");
        }
    }
}

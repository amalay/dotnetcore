using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Vehicle
{
    class HondaFactory : IVehicleFactory
    {
        private string brand = VehicleBrand.Honda;

        public ICar CreateCar(string name)
        {
            return new Car(name, brand);
        }

        public IBike CreateBike(string name)
        {
            return new Bike(name, brand);
        }        

        public IScooter CreateScooter(string name)
        {
            return new Scooter(name, brand);
        }
    }
}

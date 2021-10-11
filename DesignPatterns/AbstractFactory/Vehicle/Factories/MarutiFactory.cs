using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Vehicle
{
    class MarutiFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new MarutiBreza();
        }

        public IBike CreateBike()
        {
            return new MarutiGixxer();
        }
                

        public IScooter CreateScooter()
        {
            return new MarutiAccess125();
        }
    }
}

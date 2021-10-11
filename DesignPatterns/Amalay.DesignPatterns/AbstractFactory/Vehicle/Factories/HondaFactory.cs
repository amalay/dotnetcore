using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Vehicle
{
    class HondaFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new HondaCity();
        }

        public IBike CreateBike()
        {
            return new HondaShine();
        }        

        public IScooter CreateScooter()
        {
            return new HondaActiva();
        }
    }
}

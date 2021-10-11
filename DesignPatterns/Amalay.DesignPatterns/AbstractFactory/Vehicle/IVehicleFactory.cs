using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Vehicle
{
    public interface IVehicleFactory
    {
        ICar CreateCar();

        IBike CreateBike();

        IScooter CreateScooter();
    }
}

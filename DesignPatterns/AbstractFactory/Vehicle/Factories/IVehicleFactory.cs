using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Vehicle
{
    public interface IVehicleFactory
    {
        ICar CreateCar(string name);

        IBike CreateBike(string name);

        IScooter CreateScooter(string name);
    }
}

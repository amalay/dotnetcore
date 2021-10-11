using System;

namespace Amalay.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleClient = new AbstractFactory.Vehicle.Client();
            vehicleClient.GetVehicle();

            var phoneClient = new AbstractFactory.Phone.Client();
            phoneClient.GetPhone();
        }
    }
}

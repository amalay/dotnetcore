using System;

namespace Amalay.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var furnitureClient = new AbstractFactory.Furniture.Client();
            furnitureClient.GetFurniture();

            var vehicleClient = new AbstractFactory.Vehicle.Client();
            vehicleClient.GetVehicle();

            var phoneClient = new AbstractFactory.Phone.Client();
            phoneClient.GetPhone();
        }
    }
}

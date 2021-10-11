using System;

namespace Amalay.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Factory Pattern"

            var phoneClient = new Factory.Phone.Client();
            phoneClient.GetPhone();

            #endregion

            #region "Abstract Factory Pattern"

            var furnitureClient = new AbstractFactory.Furniture.Client();
            furnitureClient.GetFurniture();

            var vehicleClient = new AbstractFactory.Vehicle.Client();
            vehicleClient.GetVehicle();

            //var phoneClient = new AbstractFactory.Phone.Client();
            //phoneClient.GetPhone();

            #endregion
        }
    }
}

using System;

namespace Amalay.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Factory Pattern"

            Console.WriteLine("Factory Pattern");
            Console.WriteLine("===================================================================");
            
            var cardClient1 = new Factory.Card.Client();
            cardClient1.GetCard();
                        
            var phoneClient1 = new Factory.Phone.Client();
            phoneClient1.GetPhone();

            #endregion

            #region "Factory Method Pattern"

            Console.WriteLine("Factory Method Pattern");
            Console.WriteLine("===================================================================");

            var cardClient2 = new FactoryMethod.Card.Client();
            cardClient2.GetCard();
            
            var phoneClient2 = new FactoryMethod.Phone.Client();
            phoneClient2.GetPhone();

            #endregion

            #region "Abstract Factory Pattern"

            //var phoneClient3 = new AbstractFactory.Phone.Client();
            //phoneClient3.GetPhone();

            //var furnitureClient = new AbstractFactory.Furniture.Client();
            //furnitureClient.GetFurniture();

            //var vehicleClient = new AbstractFactory.Vehicle.Client();
            //vehicleClient.GetVehicle();            

            #endregion
        }
    }
}

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
            //Produce Honda family products from Honda factory. Ex. Honda City, Honda Shine, Honda Activa
            Console.WriteLine("");
            Console.WriteLine("Honda Family Products: ");
            Console.WriteLine("---------------------------------------------------------------------");
            IVehicleFactory hondaFactory = new HondaFactory();
            Console.WriteLine(hondaFactory.CreateCar().Result());
            Console.WriteLine(hondaFactory.CreateBike().Result());
            Console.WriteLine(hondaFactory.CreateScooter().Result());

            //Produce Maruti family products from Maruti factory. Ex. Maruti Breza, Mariti Gixxer, Maruti Access 125
            Console.WriteLine("");
            Console.WriteLine("Maruti Family Products: ");
            Console.WriteLine("---------------------------------------------------------------------");
            IVehicleFactory marutiFactory = new MarutiFactory();
            Console.WriteLine(marutiFactory.CreateCar().Result());
            Console.WriteLine(marutiFactory.CreateBike().Result());
            Console.WriteLine(marutiFactory.CreateScooter().Result());
        }
    }
}

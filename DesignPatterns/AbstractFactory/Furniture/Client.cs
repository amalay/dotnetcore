using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.AbstractFactory.Furniture
{
    class Client
    {
        public void GetFurniture()
        {
            //Produce Classic family products from Classic factory.
            Console.WriteLine("");
            Console.WriteLine("Classic Family Products: ");
            Console.WriteLine("---------------------------------------------------------------------");
            AbstractFurnitureFactory classicFactory = new ClassicFactory();
            Console.WriteLine(classicFactory.CreateChair().Result());
            Console.WriteLine(classicFactory.CreateSofa().Result());
            Console.WriteLine(classicFactory.CreateSofa().Result(classicFactory.CreateChair()));

            //Produce Modern family products from Modern factory.
            Console.WriteLine("");
            Console.WriteLine("Modern Family Products: ");
            Console.WriteLine("---------------------------------------------------------------------");
            AbstractFurnitureFactory modernFactory = new ModernFactory();
            Console.WriteLine(modernFactory.CreateChair().Result());
            Console.WriteLine(modernFactory.CreateSofa().Result());            
            Console.WriteLine(modernFactory.CreateSofa().Result(modernFactory.CreateChair()));
            Console.WriteLine(modernFactory.CreateSofa().Result(classicFactory.CreateChair()));
        }
    }
}

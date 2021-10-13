using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Singleton
{
    class Client
    {
        public void GetInstance()
        {            
            Console.WriteLine(Singleton1.Instance.Result());
            Console.WriteLine(Singleton2.Instance.Result());
            Console.WriteLine(Singleton3.Instance.Result());
            Console.WriteLine(Singleton4.Instance.Result());
            Console.WriteLine(Singleton5.Instance.Result());
                        
            Console.WriteLine("");
        }
    }
}

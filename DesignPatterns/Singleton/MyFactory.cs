using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Singleton
{
    public sealed class Singleton1
    {
        private static Singleton1 instance = null;

        private Singleton1() { }

        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }

                return instance;
            }
        }

        public string Result()
        {
            return "Singleton 1 - Not thread safe and should be avoid";
        }
    }

    public sealed class Singleton2
    {
        private static Singleton2 instance = null;
        private static readonly object _lock = new object();

        Singleton2() { }

        public static Singleton2 Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }

                    return instance;
                }
            }
        }

        public string Result()
        {
            return "Singleton 2 - Thread Safe with lock but performance will degrade due to lock";
        }
    }

    public sealed class Singleton3
    {
        private static readonly Singleton3 instance = new Singleton3();

        //Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        static Singleton3() { }

        private Singleton3() { }

        public static Singleton3 Instance
        {
            get
            {
                return instance;
            }
        }

        public string Result()
        {
            return "Singleton 3 - Thread Safe without lock but not quite lazy";
        }
    }

    public sealed class Singleton4
    {
        private Singleton4() { }

        public static Singleton4 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
            static Nested() { }

            internal static readonly Singleton4 instance = new Singleton4();
        }

        public string Result()
        {
            return "Singleton 4 - Thread Safe without lock and fully lazy";
        }
    }

    public sealed class Singleton5
    {
        private static readonly Lazy<Singleton5> lazy = new Lazy<Singleton5>(() => new Singleton5());

        private Singleton5() { }

        public static Singleton5 Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public string Result()
        {
            return "Singleton 5 - Best one using .NET 4's Lazy type";
        }
    }

}

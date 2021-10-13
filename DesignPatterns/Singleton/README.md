# Singleton Pattern
Singleton pattern comes under creational pattern. This pattern ensure that one and only object will be created of a class through out the application. 
In this pattern a calss must have:
- private constructor witout any parameter.
- private static instance of itself.
- public static property or method to return this instance outside the class.
- class must be sealed so that cann't ne inherited.

#### Example 1 (Not Thread Safe and should be avoid) 
```
public sealed class MyFactory
{
    private static MyFactory instance = null;

    private MyFactory() {  }

    public static MyFactory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MyFactory();
            }
            
            return instance;
        }
    }
}
```
#### Example 2 (Thread Safe with lock but performance will degrade due to lock) 
```
public sealed class MyFactory
{
    private static MyFactory instance = null;
    private static readonly object mylock = new object();

    MyFactory() {  }

    public static MyFactory Instance
    {
        get
        {
            lock (mylock)
            {
                if (instance == null)
                {
                    instance = new MyFactory();
                }
                
                return instance;
            }
        }
    }
}
```
#### Example 3 (Thread Safe without lock but not quite lazy) 
```
public sealed class MyFactory
{
    private static readonly MyFactory instance = new MyFactory();

    //Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
    static MyFactory() {  }

    private MyFactory() {  }

    public static MyFactory Instance
    {
        get
        {
            return instance;
        }
    }
}
```
#### Example 4 (Thread Safe without lock and fully lazy) 
```
public sealed class MyFactory
{
    private Singleton() {  }

    public static MyFactory Instance 
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

        internal static readonly MyFactory instance = new MyFactory();
    }
}
```
#### Example 5 (using .NET 4's Lazy<T> type) 
In .NET 4 (or higher) version, we can use the System.Lazy<T> type to make the laziness really simple. All we need to do is, pass a delegate to the constructor which calls the MyFactory constructor - which is done most easily with a lambda expression.

It's simple and performs well. It also allows you to check whether or not the instance has been created yet with the IsValueCreated property, if you need that.

The code above implicitly uses <b>LazyThreadSafetyMode.ExecutionAndPublication</b> as the thread safety mode for the Lazy<MyFactory>. Depending on the requirements, we may wish to experiment with other modes.
  
```
public sealed class MyFactory
{
    private static readonly Lazy<MyFactory> lazy = new Lazy<MyFactory>(() => new MyFactory());

    private MyFactory() {  }
  
    public static MyFactory Instance 
    { 
        get 
        { 
            return lazy.Value; 
        } 
    }
}
```

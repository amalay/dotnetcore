# Abstract Factory Design Pattern
The first thing the Abstract Factory pattern suggests is to explicitly declare interfaces for each distinct product of the product family (e.g. ICar for car, IBike for bike or IScooter for scooter).

After declaring the interfaces for each type of product, we can make all variants of products by using those interfaces. 
##### Example
All car variants can implement the Car interface (ICar)
OR
All bike variants can implement the Bike interface (IBike), and so on.

The second thing the Abstract Factory pattern suggest to produce more than one type of products from one factory. That means it produce families for products from one factory.
##### Example
Vehicle Factory of a particular manufacturer can produce "Car", "Bike" and "Scooter" and so on.
OR
Phone Factory of a particular manufacturer can produce "Feature Phone", "Smart Phone" and so on. 

To implement Abstract Factory, we have define an interface with list of creation methods for all products that are part of the product family (e.g. CreateCar, CreateBike and CreateScootere and so on). 
These methods must return abstract product types represented by the interfaces (e.g. ICar, IBike, IScooter and so on OR IFeaturePhone, ISmartPhone and so on).

Now, we can define seperate factory class for for each variant of a product family using AbstractFactory interface which should return the products of a particular family.
##### Example
Honda factory can only produce products related to Honda family (e.g. Honda City Car, Honda Shine Bike, Honda Activa Scooter and so on).
OR
Maruti factory can only produce products related to Maruti family (e.g. Maruti Breza City Car, Maruti Gixxer Bike, Maruti Access 125 Scooter and so on).

The client code has to work with both factories and products via their respective abstract interfaces. This lets you change the type of a factory that you pass to the client code, as well as the product variant that the client code receives, without breaking the actual client code.

### Diagram

![image](https://user-images.githubusercontent.com/84455469/137072875-e91fb6cb-6c56-4beb-b485-741a731c208a.png)

### Note
We can use either Interfaces or Abstract Classes or both to design our application.

#### Sample Code
- <a href="https://github.com/amalay/dotnetcore/tree/main/DesignPatterns/AbstractFactory/Vehicle">Vehicle Example using Interfaces</a>
- <a href="https://github.com/amalay/dotnetcore/tree/main/DesignPatterns/AbstractFactory/Phone">Phone Example using Interfaces</a>
- <a href="https://github.com/amalay/dotnetcore/tree/main/DesignPatterns/AbstractFactory/Furniture">Furniture Example using Abstract Classes</a>

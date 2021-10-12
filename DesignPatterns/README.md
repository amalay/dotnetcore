# Design Patterns
Design patterns are basically the best practices used by expert in software development to achieve high scalability, high maintainability, high solutionability, high flxibility and so on.

Design Patterns can be calssified into theree categories <b>Creational, Structural</b> and <b>Behavioral</b> patterns.

### Creational Design Patterns
It provide a way to create an object while hiding the creation logic instead of instantiating objects directly using new key word. It provide more flexibility to the program to decide which objects need to be created for a given use case.
##### Example
Factory Pattern, Factory Method Pattern, Abstract Factory Pattern, Singleton Pattern, Builder Pattern, Prototype patterns are the example of creational design pattern.

### Structural Design Patterns
Assembling classes and objects into larger structure while keeping the structures flexible and efficient. Inheritance is an example of this pattern.
##### Example
Adapter Pattern, Bridge Pattern, Composite Pattern, Decorator Pattern, Facade Pattern, Proxy Pattern are the example of structural design pattern.

### Behavioral Design Patterns
This design pattern focus on communication between objects.
##### Example
Chain of Responsibility Pattern, Observer Pattern, Iterator Pattern and so on are the example of behavioral design patter.


## Factory Pattern
Creates objects without exposing the instantiation logic to the client.

```
CardFactory factory = new CardFactory();

AbstractCard visaDebitCard = factory.CreateCard(CardName.Platinum, CardBrand.Visa, CardType.DebitCard);
AbstractCard visaCreditCard = factory.CreateCard(CardName.Platinum, CardBrand.Visa, CardType.CreditCard);

AbstractCard masterDebitCard = factory.CreateCard(CardName.Platinum, CardBrand.Master, CardType.DebitCard);
AbstractCard masterCreditCard = factory.CreateCard(CardName.Platinum, CardBrand.Master, CardType.CreditCard);
```
OR
```
var factory = new PhoneFactory();

var nokiaFeaturePhone = factory.CreateFeaturePhone(PhoneName.Nokia3310, PhoneBrand.Nokia);
var nokiaSmartPhone = factory.CreateSmartPhone(PhoneName.NokiaPixel, PhoneBrand.Nokia);

var samsungFeaturePhone = factory.CreateFeaturePhone(PhoneName.SamsungGuru, PhoneBrand.Samsung);
var samsungSmartPhone = factory.CreateSmartPhone(PhoneName.SamsungGalaxy, PhoneBrand.Samsung);
```

## Factory Method Pattern
Define an interface for creating an object, but let subclasses decide which class to instantiate.
```
AbstractCardFactory debitCardFactory = new DebitCardFactory();
debitCardFactory.CreateCard().Result();

AbstractCardFactory creditCardFactory = new CreditCardFactory();
creditCardFactory.CreateCard().Result();
```
OR
```
IPhoneFactory featurePhoneFactory = new FeaturePhoneFactory();
featurePhoneFactory.CreatePhone().Result();          

IPhoneFactory smartPhoneFactory = new SmartPhoneFactory();
smartPhoneFactory.CreatePhone().Result();
```
## Abstract Factory Pattern
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
```
```
OR
```
IPhoneFactory nokiaFactory = new NokiaFactory();
nokiaFactory.CreateFeaturePhone().Result();
nokiaFactory.CreateSmartPhone().Result();

IPhoneFactory samsungFactory = new SamsungFactory();
samsungFactory.CreateFeaturePhone().Result();
samsungFactory.CreateSmartPhone().Result();
```

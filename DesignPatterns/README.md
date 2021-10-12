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
AbstractCard visaDebitCard = debitCardFactory.CreateCard(CardName.Gold, CardBrand.Visa);

AbstractCardFactory creditCardFactory = new CreditCardFactory();
AbstractCard visaCreditCard = creditCardFactory.CreateCard(CardName.Platinum, CardBrand.Visa);
```
OR
```
IPhoneFactory featurePhoneFactory = new FeaturePhoneFactory();
IPhone featurePhone = featurePhoneFactory.CreatePhone(PhoneName.Nokia3310, PhoneBrand.Nokia);

IPhoneFactory smartPhoneFactory = new SmartPhoneFactory();
IPhone smartPhone = smartPhoneFactory.CreatePhone(PhoneName.NokiaPixel, PhoneBrand.Nokia);
```
## Abstract Factory Pattern
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
```
AbstractCardFactory visaCardFactory = new VisaCardFactory();
AbstractCard visaDebitCard = visaCardFactory.CreateDebitCard(CardName.Gold);
AbstractCard visaCreditCard = visaCardFactory.CreateCreditCard(CardName.Gold);

AbstractCardFactory masterCardFactory = new MasterCardFactory();
AbstractCard masterDebitCard = masterCardFactory.CreateDebitCard(CardName.Platinum);
AbstractCard masterCreditCard = masterCardFactory.CreateCreditCard(CardName.Platinum);
```
OR
```
IPhoneFactory nokiaPhoneFactory = new NokiaFactory();
IPhone nokiaFeaturePhone = nokiaPhoneFactory.CreateFeaturePhone(PhoneName.Nokia3310);
IPhone nokiaSmartPhone = nokiaPhoneFactory.CreateSmartPhone(PhoneName.NokiaPixel);

IPhoneFactory samsungPhoneFactory = new SamsungFactory();
IPhone samsungFeaturePhone = samsungPhoneFactory.CreateFeaturePhone(PhoneName.SamsungGuru);
IPhone samsungSmartPhone = samsungPhoneFactory.CreateSmartPhone(PhoneName.SamsungGalaxy);
```

# SOLID Principle
SOLID ia a design principle used in software industry. The objective of this principle is to make software Scalable, Maintainable, Loosely coupled, Encapsulated etc.
The major flaws in design to fail the software are as below:
- Assigning more and more responsibility to a single class.
- Depending one class on another class.
- Spreading/Introducing duplicate code in the system.

SOLID principle provide great help to overcome these design flaws.

## SOLID Principle Details

- S: Single Responsibility Principle (SRP)
- O: Open Closed Principle (OSP)
- L: Liskov Substitution Principle (LSP)
- I: Interface Segregation Principle (ISP)
- D: Depedency Inversion Principle (DIP)

### S: Single Responsibility Principle (SRP)
A Class or Module or Function should have only one job to do. In another words, our Class or Module or Function should have only one reason to change. 
It should not be like Swiss knife wherein if one of them need to change then entire tool need to be altered. It does not mean that Class should only contain one method or property. There may be many members as long as they relate to single responsibility.
##### Example
User registration and Sending email are two distinct functionalities and there is no relation between them so there should be two seperate classes for both the functionality.

![image](https://user-images.githubusercontent.com/84455469/137142137-7a2e2a4e-ec18-4b55-b283-02995f984a34.png)

In example 1 we can see that UserRegistration class is not following Single Responsibility Principle (SRP) because SendEmail and EmailValidation methods are totally different functionality so these method should belong to UserRegistration class. Hence it is seperated in example 2 to follow Single Responsibility Principle (SRP).

### O: Open Closed Principle (OSP)
A Class or Module should be open for extension but closed for modification.<br/>
"<b>Open for extension</b>" means, we need to design our module/class in such a way that the new functionality can be added only when new requirements are generated. We can use inheritance for extension.<br/>
"<b>Closed for modification</b>" means we have already developed a class and it has gone through unit testing. We should then not alter it until we find bugs.

##### Example

![image](https://user-images.githubusercontent.com/84455469/137136281-c9998e16-aaae-493f-bc96-8e94cd2afecb.png)

Example 1, Calculator class is used to calculate the area of rectangle and it is perfect. 
But lets say tomorrow if we want extend Calculator class by adding one more method to calcuate area of circle then what will happen? Definetely Example 2 is one of the solution and it will work well. But we can see that for every new method we haveto modify Calculator class with multiple if-else statements. That means it is not following Open Closed Principle (OSP).
Now see the example 3, we can add n-number of functionality without modifing the Calculator class. We only need to do is, declare one class for each new functionality. Hence it is open for extension but closed for modification

### L: Liskov Substitution Principle (LSP)
The Liskov Substitution Principle (LSP) is just an extension of the Open Closed Principle and ensure that a new class can be derived from a base class without changing their behavior. In another words, a derived class must be substitutable for its base class.

##### Example

![image](https://user-images.githubusercontent.com/84455469/137278862-afb355ce-f10b-4820-8ebb-9c0c84a94fe4.png)

### I: Interface Segregation Principle (ISP)
Interface Segregation Principle (ISP) states that clients should not be forced to implement methods of the interfaces which they don't use. Instead of one fat interface should be splitted into many small interfaces with related methods so that calient can easily consume the interfarces without implementing unnecessary methods.

##### Example
![image](https://user-images.githubusercontent.com/84455469/137290401-2b046be0-6962-4e28-9208-e85cdc5bd718.png)

### D: Depedency Inversion Principle (DIP)
Dependency Inversion Principle (DIP) states that high-level modules/classes should not depend on low-level modules/classes. 
Both higl-level and low-level module/classes should depend upon abstractions. And abstractions should not depend upon details rather Details should depend upon abstractions.

High-level modules/classes implement business rules or logic in a system (application). Low-level modules/classes deal with more detailed operations; in other words they may deal with writing information to databases or passing messages to the operating system or services. So we must keep these high-level and low-level modules/classes loosely coupled as much as we can. To do that, we need to make both of them dependent on abstractions instead of knowing each other.

##### Example
![image](https://user-images.githubusercontent.com/84455469/137316213-65b84cf7-4833-4091-a017-0ed3c20652e3.png)


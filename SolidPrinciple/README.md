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

![image](https://user-images.githubusercontent.com/84455469/137103971-9c9abf30-f49a-4229-8bb5-761bcec70e00.png)

### O: Open Closed Principle (OSP)
A Class or Module should be open for extension but closed for modification.
"<b>Open for extension</b>" means, we need to design our module/class in such a way that the new functionality can be added only when new requirements are generated. We can use inheritance for extension. 
"<b>Closed for modification</b>" means we have already developed a class and it has gone through unit testing. We should then not alter it until we find bugs.

# SOLID Principle
SOLID ia a design principle used in software industry. The objective of this principle is to make software Scalable, Maintainable, Loosely coupled, Encapsulated etc.
The major flaws in design to fail the software are as below:
- Assigning more and more responsibility to a single class.
- Depending one class on another class.
- Spreading/Introducing duplicate code in the system.

SOLID principle provide great help to overcome these design flaws.

## SOLID Principle Details

- S: Single Responsibility Principle (SRP)
- O: Open Closed Principle (OCP)
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

### O: Open Closed Principle (OCP)
A Class or Module should be open for extension but closed for modification.<br/>
"<b>Open for extension</b>" means, we need to design our module/class in such a way that the new functionality can be added only when new requirements are generated. We can use inheritance for extension.<br/>
"<b>Closed for modification</b>" means we have already developed a class and it has gone through unit testing. We should then not alter it until we find bugs.

##### Example

![image](https://user-images.githubusercontent.com/84455469/137136281-c9998e16-aaae-493f-bc96-8e94cd2afecb.png)

In example 1, Calculator class is used to calculate the area of rectangle and it is perfect. <br/><br/>
But lets say tomorrow if we want to extend the Calculator class by adding one more method to calcuate area of circle then what will happen? Definetely example 2 is one of the solution and it will work well. But we can see that for every new method we have to modify the Calculator class with multiple if-else statements. That means it is not following Open Closed Principle (OCP).<br/><br/>
Now see the example 3, we can add n-number of functionalities without modifing the Calculator class. We only need to do is, declare one class for each new functionality. Hence it is open for extension but closed for modification and thats what the Open Closed Principle (OCP) is.

### L: Liskov Substitution Principle (LSP)
The Liskov Substitution Principle (LSP) is just an extension of the Open Closed Principle and ensure that a new class can be derived from a base class without changing their behavior. In another words, a derived class must be substitutable for its base class.

##### Example

![image](https://user-images.githubusercontent.com/84455469/137278862-afb355ce-f10b-4820-8ebb-9c0c84a94fe4.png)

In example 1, we want to define a class with read and write operations in file. For this we have defined one File class and one FileManager class with required functionalities and it work well.<br/><br/>
Now tomorrow if we want to restrict write operation based on some condition. Means if file is readonly then write operation should not be performed. 
To achieve this we have extended the File class and create one ReadOnlyFile class as shown in example 2. <br/><br/>But what is wrong here?? <br/><br/>Firstly, In ReadOnlyFile class we are throwing exception into the SaveData method explicitly and secondly, we are modifying the FileManager class by adding some explicit condition into SaveDataIntoFile method. That means derived class is not a substitutable of it base class.<br/><br/>
Now come to example 3, to implement Liskov Substitution Principle (LSP), we have restructured the program and spilt the File class into multiple classes based on the functionalities using interfaces. Here we can see that any of the derived class can easily substitute its base class. 

### I: Interface Segregation Principle (ISP)
Interface Segregation Principle (ISP) states that clients should not be forced to implement methods of the interfaces which they don't use. Instead of one fat interface should be splitted into many small interfaces with related methods so that calient can easily consume the interfarces without implementing unnecessary methods.

##### Example
![image](https://user-images.githubusercontent.com/84455469/137495730-cf3bae7a-4d72-40ab-b011-0dab8bd9c67f.png)

In example 1, we can see that ITask interface have three methods "CreateTask", "AssignTask" and "Development". All three methods are relavent for TeamLead class and has been implement by "TeamLead" class. But Development method of the ITask interface is not relavent for "Manager" class because generally manager don't do the development. But here we are forcing the "Manager" class to implement "Development" method also unnecessarily. To mitigate this issue Interface Segregation Principle (ISP) is need to be followed.<br/><br/>
Now in example 2, we have splited fatty interface ITask into two small interfaces called ITask and IDevelopment with relavent methods. Now "Manager" class need to implement only ITask interface and "TeamLead" class can implement both ITask and IDevelopment interfaces. And thats what Interface Segregation Principle (ISP) is.

### D: Depedency Inversion Principle (DIP)
Dependency Inversion Principle (DIP) states that high-level modules/classes should not depend on low-level modules/classes. 
Both higl-level and low-level module/classes should depend upon abstractions. And abstractions should not depend upon details rather Details should depend upon abstractions.

High-level modules/classes implement business rules or logic in a system (application). Low-level modules/classes deal with more detailed operations; in other words they may deal with writing information to databases or passing messages to the operating system or services. So we must keep these high-level and low-level modules/classes loosely coupled as much as we can. To do that, we need to make both of them dependent on abstractions instead of knowing each other.

##### Example
![image](https://user-images.githubusercontent.com/84455469/137316213-65b84cf7-4833-4091-a017-0ed3c20652e3.png)

In example 1, we can see that ExceptionLogger class is used to log the exception into file using "FileLogger" class and it is working perfectly.<br/><br/>
Now tomorrow, we want to categorise our exception logging mechanism to log SQL exception into database while keeping the existing file logging as it. To achieve this, we have defined one more class as "DbLogger" and consuming that class inside ExceptionLogger class. Which is also good but you can see that for each new type of exception, we have to modify ExceptionLogger and that will impact whole system along with existing clients.<br/><br/>
Now to mitigate this issue, we have to de-couple the structure in such a way that ExceptionLogger is not needed to modify at all. <br/><br/>
In example 3, we have de-coupled the design using ILogger interface. Now you can see that both high-level and low-level classes are depending on abstraction (i.e. ILogger) instead of knowing each other. And thats what Depedency Inversion Principle (DIP) is.

Even in future, if want to extend it further by adding one more type of exception (lets say EventLogger) then also there is no need to modify the "ExceptionLogger" logger class at all as shown in example 4. And we can keep extending without impacting the existing system.


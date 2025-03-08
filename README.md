**Order Processing System - SOLID Principles in .NET Core MVC**
This is a basic Order Processing System built using ASP.NET Core MVC while following the SOLID principles of Object-Oriented Programming. 

**SOLID Principles Implementation**
**1. Single Responsibility Principle (SRP)**
Principle: A class should have one, and only one, reason to change. In other words, a class should have only one job or responsibility.
Classes and Controllers:
OrderController: Responsible for handling user actions related to orders. It receives requests from the UI, processes data, and returns appropriate views.
NotificationService: This class is responsible for sending notifications (like email) after an order is placed. It only handles the notification logic and nothing else.

**2. Open/Closed Principle (OCP)**
Principle: A class should be open for extension but closed for modification. This means you should be able to add new functionality to a class without changing its existing code.
Interfaces:
INotificationSender: The interface allows different types of notifications (for example EmailNotificationService) to be added in the future without modifying the core order processing logic.

**3. Liskov Substitution Principle (LSP**)
Principle: Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
Classes and Interfaces:
INotificationSender Interface and its Implementations (EmailNotificationService).

**4. Interface Segregation Principle (ISP)**
Principle: Clients should not be forced to depend on interfaces they do not use.
Interfaces:
INotificationSender: The interface defines a single method (SendNotification), and clients only need to implement this method.

**5. Dependency Inversion Principle (DIP)**
Principle: High-level modules should not depend on low-level modules. Both should depend on abstractions. Furthermore, abstractions should not depend on details. Details should depend on abstractions.
Program and Services:
Program.cs: Dependency Injection (DI) is used to inject dependencies into the controllers and services.
The OrderController depends on INotificationSender and IOrderProcessor (interfaces) instead of directly depending on concrete classes like EmailNotificationService or OrderProcessingService.

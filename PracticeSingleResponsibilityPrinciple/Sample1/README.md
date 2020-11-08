# Sample1
This sample is practiced using the article of  [Single Responsibility Principle: The Art of Great Code | Toptal](https://www.toptal.com/software/single-responsibility-principle "Single Responsibility Principle: The Art of Great Code | Toptal")

## Structure
- Before SRP  
The code samples are before applying the principal. 
I focus an `OrderController` class.  
  > That is simply too many jobs for a single class. For every little change, the developer needs to change the entire controller’s code. 

- After SRP  
  > The class Controllers should only control the overall process, and not actually house every bit of logic of the process.  
  
- Before Dependency Injection  
The code samles are after applying the SRP. 
I focus an `OderService` class. 
  > It is hard to imagine a large project based on Single Responsibility Principle without Dependency Injection. 

- After Dependency Injection  
  > The OrderService now relies on IOrderRepository interface to interact with the component that stores all our orders. It no longer cares about how that interface is implemented and what storage technology is powering it. Now OrderService class has only code that deals with order business logic.

- Before Event Driven Architecture
The code samles are after applying the Event Driven Architecture.
I focus a `Create` method in the `OrderService` class.
  > Whenever an order is created, instead of sending an email directly from the OrderService class, special event class OrderCreated is created and an event is generated. Somewhere in the application event handlers will be configured. One of them will send an email to the client.

- Before Event Driven Architecture
  > Some may argue that it is now difficult to understand what is going on when you create the order. But that cannot be any further from the truth. If you feel that way, simply take advantage of your IDE’s functionality. By finding all the usages of OrderCreated class in the IDE, we can see all the actions associated with the event.  
  
  > But when should I use Dependency Injection and when should I use an Event-driven approach? It is not always easy to answer this question, but one simple rule that may help you is to use Dependency Injection for all your main activities within the application, and Event-driven approach for all secondary actions. For example, use Dependecy Injection with things like creating an order within the OrderService class with IOrderRepository, and delegate sending of email, something that is not a crucial part of the main order creation flow, to some event handler.

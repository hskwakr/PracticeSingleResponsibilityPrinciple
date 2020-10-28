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

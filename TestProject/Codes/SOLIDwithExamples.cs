namespace TestProject.Codes;

/*
The SOLID principles are a set of design principles that help you create more maintainable,
flexible, and scalable software. SOLID is an acronym for five principles:

S – Single Responsibility Principle (SRP)
O – Open/Closed Principle (OCP)
L – Liskov Substitution Principle (LSP)
I – Interface Segregation Principle (ISP)
D – Dependency Inversion Principle (DIP)
Let’s explore these principles with examples in C#:
*/

/*
1. Single Responsibility Principle (SRP)
A class should have only one reason to change, meaning it should only have one job or responsibility.

Example:
Before SRP:
public class Invoice
{
    public void CalculateTotal() { calculation logic }
    public void SaveInvoiceToDatabase() { save logic }
}
The Invoice class has two responsibilities: calculating the total and saving to the database.

After SRP:
public class Invoice
{
    public void CalculateTotal() { calculation logic }
}

public class InvoiceRepository
{
    public void Save(Invoice invoice) { save logic }
}
Now, the Invoice class is only responsible for calculation,
and the InvoiceRepository is responsible for saving the invoice.



2. Open/Closed Principle (OCP)
Software entities should be open for extension but closed for modification.
This means you can add new functionality without changing the existing code.

Example:
Before OCP:
public class DiscountCalculator
{
    public double CalculateDiscount(Order order)
    {
        if (order.Type == "Standard")
            return 0.1;
        else if (order.Type == "Premium")
            return 0.2;
        return 0;
    }
}
If we need to add a new order type, we'd have to modify the CalculateDiscount method.
After OCP:
public interface IDiscountStrategy
{
    double CalculateDiscount(Order order);
}

public class StandardDiscount : IDiscountStrategy
{
    public double CalculateDiscount(Order order) => 0.1;
}

public class PremiumDiscount : IDiscountStrategy
{
    public double CalculateDiscount(Order order) => 0.2;
}

public class DiscountCalculator
{
    private readonly IDiscountStrategy _discountStrategy;

    public DiscountCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double CalculateDiscount(Order order)
    {
        return _discountStrategy.CalculateDiscount(order);
    }
}
Now, adding a new order type doesn't require modifying existing classes. We just add a new strategy class.



3. Liskov Substitution Principle (LSP)
Objects of a superclass should be replaceable with objects of a subclass 
without affecting the correctness of the program.

Example:
Before LSP:
public class Bird
{
    public void Fly() { flying logic }
}

public class Ostrich : Bird
{
    public new void Fly() { throw new NotSupportedException(); } // Ostriches can't fly!
}
Ostrich violates LSP because it changes the behavior of Fly(), which is expected from Bird.

After LSP:
public class Bird
{
    public virtual void Move() { default movement logic }
}

public class Sparrow : Bird
{
    public override void Move() { flying logic }
}

public class Ostrich : Bird
{
    public override void Move() { running logic }
}
Now, both Sparrow and Ostrich implement Move() without breaking the contract.



4. Interface Segregation Principle (ISP)
Clients should not be forced to implement interfaces they don’t use.
Split large interfaces into smaller, more specific ones.

Example:
Before ISP:
public interface IWorker
{
    void Work();
    void Eat();
}

public class Worker : IWorker
{
    public void Work() { working logic }
    public void Eat() { eating logic }
}

public class Robot : IWorker
{
    public void Work() { working logic }
    public void Eat() { throw new NotImplementedException(); } // Robots don’t eat!
}
The Robot class is forced to implement Eat(), which doesn’t make sense.

After ISP:
public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class Worker : IWorkable, IEatable
{
    public void Work() { working logic }
    public void Eat() { eating logic }
}

public class Robot : IWorkable
{
    public void Work() { working logic }
}



5. Dependency Inversion Principle (DIP)
High-level modules should not depend on low-level modules.
Both should depend on abstractions. Abstractions should not depend on details.
Details should depend on abstractions.

Example:
Before DIP:
public class FileLogger
{
    public void Log(string message) { log to file }
}

public class Application
{
    private FileLogger _fileLogger;

    public Application()
    {
        _fileLogger = new FileLogger(); // Direct dependency on FileLogger
    }

    public void Run()
    {
        _fileLogger.Log("Application started.");
    }
}
The Application class directly depends on FileLogger.

After DIP:
public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message) { log to file }
}

public class Application
{
    private readonly ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger; // Dependency injected via constructor
    }

    public void Run()
    {
        _logger.Log("Application started.");
    }
}
Now, the Application class depends on the ILogger abstraction, not the concrete FileLogger class.
We can inject different logging mechanisms if needed.
*/

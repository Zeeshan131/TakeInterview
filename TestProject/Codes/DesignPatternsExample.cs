namespace TestProject.Codes;

// Design Patterns with Example

// Design patterns are widely used in software development to solve common problems in object-oriented design.



/*
1. Singleton Pattern (Creational Design Pattern)
The Singleton Pattern ensures that a class has only one instance and provides a global point of access to it.

Example:
*/
// Singleton Class:
public class Singleton
{
    private static Singleton _instance;

    // Private constructor to prevent instantiation from outside
    private Singleton() { }

    // Public method to provide access to the instance
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    // Sample method
    public void ShowMessage()
    {
        Console.WriteLine("Singleton Instance: Hello World!");
    }
}



/*
2. Factory Method Pattern (Creational Design Pattern)
The Factory Method Pattern defines an interface for creating objects,
but lets subclasses alter the type of objects that will be created.

Example:
*/
// Product Interface:
public interface IProduct
{
    void DoSomething();
}
// Concrete Product 1:
public class ProductA : IProduct
{
    public void DoSomething()
    {
        Console.WriteLine("Product A is doing something!");
    }
}
// Concrete Product 2:
public class ProductB : IProduct
{
    public void DoSomething()
    {
        Console.WriteLine("Product B is doing something!");
    }
}
// Creator (Factory):
public abstract class Creator
{
    public abstract IProduct FactoryMethod();
}
// Concrete Creator 1:
public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ProductA();
    }
}
// Concrete Creator 2:
public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ProductB();
    }
}



/*
3. Observer Pattern (Behavioral Design Pattern)
The Observer Pattern defines a one-to-many dependency relationship,
where one object (subject) notifies other objects (observers) about changes in its state.

Example:
*/
// Observer Interface:
public interface IObserver
{
    void Update(string message);
}
// Subject (Publisher):
public class Subject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}
// Concrete Observer 1:
public class ConcreteObserver : IObserver
{
    private string _name;

    public ConcreteObserver(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received: {message}");
    }
}



/*
4. Strategy Pattern (Behavioral Design Pattern)
The Strategy Pattern allows selecting an algorithm at runtime,
enabling a family of algorithms to be defined and interchangeable.

Example:
*/
// Strategy Interface:
public interface IStrategy
{
    void Execute();
}
// Concrete Strategy 1:
public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy A: Performing operation A");
    }
}
// Concrete Strategy 2:
public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy B: Performing operation B");
    }
}
// Context:
public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}



/*
5. Decorator Pattern (Structural Design Pattern)
The Decorator Pattern allows for adding responsibilities to an object dynamically,
without affecting the behavior of other objects from the same class.

Example:
*/
// Component Interface:
public interface IComponent
{
    void Operation();
}
// Concrete Component:
public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("Concrete Component: Operation performed.");
    }
}
// Decorator:
public class Decorator : IComponent
{
    protected IComponent _component;

    public Decorator(IComponent component)
    {
        _component = component;
    }

    public virtual void Operation()
    {
        _component.Operation();
    }
}
// Concrete Decorator 1:
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) : base(component) { }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorA: Additional behavior added.");
    }
}
// Concrete Decorator 2:
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) : base(component) { }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorB: Another behavior added.");
    }
}

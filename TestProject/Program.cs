using TestProject.Codes;

// HashTableExample.HashTableEx();

// int[] nums = [120, 4, 59, 8, 29, -74, 5, 92];
// int l = nums.Length;
// ThirdLargestNumber.ThirdLargest(nums, l);

//// ExtensionMethodExample
// string s = "kak";
// bool res = s.CheckIfPalindrom();
// Console.WriteLine(res);
// int num = 3;
// string res = num.ToOrdinal();
// Console.WriteLine(res);

//// ThreadAndAsyncAwaitExample
// ThreadAndAsyncAwaitExample ta = new ThreadAndAsyncAwaitExample();
// ta.ProcessData();
// await ta.ProcessDataAsync();

// DelegatesExample2 dle = new DelegatesExample2();
// dle.start();

// Console.WriteLine(GenericExample.Identity(43));
// Console.WriteLine(GenericExample.Identity("Fourty Three"));

//// DesignPatternsExample
// 1. Singleton Pattern
// Singleton singleton = Singleton.GetInstance();
// singleton.ShowMessage();
// 2. Factory Method Pattern
// Creator creator = new ConcreteCreatorA();
// IProduct product = creator.FactoryMethod();
// product.DoSomething();
// 3. Observer Pattern
// var subject = new Subject();
// var observer1 = new ConcreteObserver("Observer 1");
// var observer2 = new ConcreteObserver("Observer 2");
// subject.AddObserver(observer1);
// subject.AddObserver(observer2);
// subject.NotifyObservers("Hello Observers!");
// 4. Strategy Pattern
// IStrategy strategyA = new ConcreteStrategyA();
// IStrategy strategyB = new ConcreteStrategyB();
// Context context = new Context(strategyA);
// context.ExecuteStrategy();
// context.SetStrategy(strategyB);
// context.ExecuteStrategy();
// Decorator Pattern
IComponent component = new ConcreteComponent();
IComponent decoratedA = new ConcreteDecoratorA(component);
IComponent decoratedB = new ConcreteDecoratorB(decoratedA);
decoratedB.Operation();
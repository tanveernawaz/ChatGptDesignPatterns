using ChatGptDesignPatterns;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

class Program
{
    private static void Main(string[] args)
    {
        //Singleton

        // Singleton st = Singleton.Instance;
        // Console.WriteLine("Hello, World! Singleton");

        // //Factory

        // Creator creatorA = new ConcreteCreatorA();
        // IProduct productA = creatorA.FactoryMethod();
        // Console.WriteLine(productA.Operation());
        // Creator creatorB = new ConcreteCreatorB();
        // IProduct productB = creatorB.FactoryMethod();
        // Console.WriteLine(productB.Operation());


        //Builder

        //BLTSandwichBuilder bltBuilder = new BLTSandwichBuilder();
        //SandwichMaker sandwichMaker = new SandwichMaker(bltBuilder);
        //sandwichMaker.BuildSandwich();
        //Sandwich sandwich = sandwichMaker.GetSandwich();
        //Console.WriteLine("Bread Type: " + sandwich.BreadType);
        //Console.WriteLine("Meat Type: " + sandwich.MeatType);
        //Console.WriteLine("Cheese Type: " + sandwich.CheeseType);
        //Console.WriteLine("Is Toasted: " + sandwich.IsToasted);
        //Console.WriteLine("Vegetables: " + string.Join(", ", sandwich.Vegetables));

        //Abstract Factory

        //HotDrinkMachine machine = new HotDrinkMachine();
        //IHotDrink tea = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
        //tea.Consume();
        //IHotDrink coffee = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Coffee, 200);
        //coffee.Consume();

        //Object Pool

        //ConnectionPool pool = new ConnectionPool(5);
        //Connection connection = ConnectionFactory.GetConnectionFromPool(pool);
        //ConnectionFactory.ReleaseConnectionToPool(pool, connection);

        //Prototype

        //Circle c = new Circle(1, 2, 3);
        //Circle c1 = (Circle)c.Clone();
        //c1.X = 4;
        //c.Draw();
        //c1.Draw();

        //Adapter Structural Design Pattern

        //Adaptee adaptee = new Adaptee();
        //ITarget target = new Adapter(adaptee);
        //target.Request();

        //Bridge

        //var tvRemote = new TVRemoteControl(new BasicRemote());
        //tvRemote.TurnOn(); // Basic remote is turning on the device.
        //tvRemote.TurnOff(); // Basic remote is turning off the device.

        //Composite Design Pattern

        // Create a tree structure 
        //Composite root = new Composite("root");
        //root.Add(new Leaf("Leaf A"));
        //root.Add(new Leaf("Leaf B"));

        //Composite comp = new Composite("Composite X");
        //comp.Add(new Leaf("Leaf XA"));
        //comp.Add(new Leaf("Leaf XB"));
        //root.Add(comp);

        //Composite comp2 = new Composite("Composite XY");
        //comp2.Add(new Leaf("Leaf XYA"));
        //comp2.Add(new Leaf("Leaf XYB"));
        //comp.Add(comp2);

        //// Add and remove a leaf
        //Leaf leaf = new Leaf("Leaf C");
        //root.Add(leaf);
        //root.Remove(leaf);

        //// Display the tree
        //root.Display(1);

        //Console.ReadKey();



        //Decorator Design Pattern

        //IDecoComponent component = new ConcreteComponent();
        //component.Operation();

        //component = new ConcreteDecoratorA(component);
        //component.Operation();

        //component = new ConcreteDecoratorB(component);
        //component.Operation();

        //Console.ReadKey();



        //Facade Design Pattern

        //var complexSystem = new ComplexSystem();
        //var facade = new Façade(complexSystem);

        //facade.Method1();
        //facade.Method2();

        //Flyweight

        //var factory = new FlyweightFactory();

        //var fx = factory.GetFlyweight(1);
        //fx.Operation(2);


        //Proxy

        //var proxy = new Proxy();
        //proxy.Request();



        //Chain of Responsibility

        // Create the chain of responsibility
        //Handler h1 = new ConcreteHandlerA();
        //Handler h2 = new ConcreteHandlerB();
        //Handler h3 = new ConcreteHandlerC();
        //h1.SetSuccessor(h2);
        //h2.SetSuccessor(h3);

        //// Generate and process requests
        //int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

        //foreach (int request in requests)
        //{
        //    h1.HandleRequest(request);
        //}

        //Console.ReadKey();


        //Command

        //var invoker = new Invoker();
        //var command = new SimpleCommand("Command Design Pattern");
        //invoker.SetCommand(command);
        //invoker.ExecuteCommand();


        //Interpreter

        //Context context = new Context();
        //AbstractExpression expression = new TerminalExpression();
        //expression.Interpret(context);

        //StockMarket stockMarket = new StockMarket();
        //StockTrader trader1 = new StockTrader();
        //StockTrader trader2 = new StockTrader();

        //stockMarket.RegisterObserver(trader1);
        //stockMarket.RegisterObserver(trader2);

        //stockMarket.SetStockPrice(100.0f); // this will notify the observer
        //stockMarket.SetStockPrice(120.0f); // this will notify the observer

        //State Design Pattern

        //StateContext context = new StateContext();
        //context.Request(); // Output: Handling in State A

        //context.CurrentState = new StateB();
        //context.Request(); // Output: Handling in State B


        //Visitor Design Pattern

        //ObjectStructure objectStructure = new ObjectStructure();
        //objectStructure.Attach(new ElementA());
        //objectStructure.Attach(new ElementB());

        //ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
        //ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

        //objectStructure.Accept(visitor1);
        //objectStructure.Accept(visitor2);


        //Memento Design Pattern

        var editor = new Editor();
        var history = new History();

        editor.Content = "Hello";
        history.Push(editor.CreateMemento());

        editor.Content = "Hello World";
        history.Push(editor.CreateMemento());

        editor.Content = "Hello World!";
        history.Push(editor.CreateMemento());

        editor.Content = "Hello World! How are you?";
        history.Push(editor.CreateMemento());

        editor.Restore(history.Pop());
        Console.WriteLine(editor.Content); // "Hello World! How are you?"

        editor.Restore(history.Pop());
        Console.WriteLine(editor.Content); // "Hello World!"

        editor.Restore(history.Pop());
        Console.WriteLine(editor.Content); // "Hello World"

        editor.Restore(history.Pop());
        Console.WriteLine(editor.Content); // "Hello"

    }
}


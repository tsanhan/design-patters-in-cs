using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstructFactory;
using Bridge;
using Singleton;
using Builder;
using Builder.Item;
using Builder.Packing;
using Prototype;
using Adapter;
using Composite;
using Proxy;
using Flyweight;
using Facade;
using Decorator;
using TemplateMethod;
using Mediator;
using ChainOfResponsibility;
using Observer;
using Visitor;
using State;
using Strategy;
using Command;
using Interpreter;
using Iterator;
using Memento;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Adapter();
            //Composite();
            // Proxy();
            //FlyweightTest();
            //Facade();
            //BridgeTest();
            DecoratorTest();
            //TemplateMethodTest();
            //Mediator();
            //ChainOfResponsibility();
            //ObserverTest();
            //StrategyTest();
            //CommandTest();
            //StateTest();
            //VisitorTest();
            //InterpreterTest();
            //IteratorTest();
            //MementoTest();
            Console.ReadKey();
        }

        #region Patterns

        #region AbstructFactory
        static void AbstructFactory()
        {
            //get shape factory
            AbstructFactory.AbstructFactory shapeFactory = FactoryProducer.getFactory("SHAPE");

            //get an object of Shape Circle
            AbstructFactory.Shape shape1 = shapeFactory.GetShape("CIRCLE");

            //call draw method of Shape Circle
            shape1.Drow();

            //get an object of Shape Rectangle
            AbstructFactory.Shape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call draw method of Shape Rectangle
            shape2.Drow();

            //get an object of Shape Square 
            AbstructFactory.Shape shape3 = shapeFactory.GetShape("SQUARE");

            //call draw method of Shape Square
            shape3.Drow();

            //get color factory
            AbstructFactory.AbstructFactory colorFactory = FactoryProducer.getFactory("COLOR");

            //get an object of Color Red
            AbstructFactory.Color color1 = colorFactory.GetColor("RED");

            //call fill method of Red
            color1.Fill();

            //get an object of Color Green
            AbstructFactory.Color color2 = colorFactory.GetColor("Green");

            //call fill method of Green
            color2.Fill();

            //get an object of Color Blue
            AbstructFactory.Color color3 = colorFactory.GetColor("BLUE");

            //call fill method of Color Blue
            color3.Fill();
        }
        #endregion

        #region Singleton
        static void Singleton()
        {
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is protected
            //SingleObject object = new SingleObject();


            //Get the only object available
            SingleObject obj = SingleObject.getInstance;

            obj.showMessage();
        }
        #endregion

        #region Builder
        static void Builder()
        {
            //the Meal Builder:
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.prepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Total Cost: " + vegMeal.getCost());

            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            Console.WriteLine("\n\nNon-Veg Meal");
            nonVegMeal.showItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.getCost());

            //the Computer Bulder
            Computer comp = new ComputerBuilder("500 GB", "2 GB").setBluetoothEnabled(true).setGraphicsCardEnabled(true).build();

        }
        #endregion

        #region Prototype
        static void Prototype()
        {
            Employees emps = new Employees();
            emps.loadData();

            Employees NewEmps = emps.Clone() as Employees;
            Employees NewEmps1 = emps.Clone() as Employees;

            List<string> List = NewEmps.getList();
            List.Add("John");

            List<string> List1 = NewEmps1.getList();
            List1.RemoveAt(0);


            Console.Write("emps List: ");
            foreach (string s in emps.getList()) Console.Write(" " + s + " ");
            Console.WriteLine();

            Console.Write("NewEmps List: ");
            foreach (string s in List) Console.Write(" " + s + " ");
            Console.WriteLine();

            Console.Write("NewEmps1 List: ");
            foreach (string s in List1) Console.Write(" " + s + " ");

        }
        #endregion

        #region AdapterMethods
        static void Adapter()
        {
            testObjectAdapter();
            testClassAdapter();
        }

        private static void testObjectAdapter()
        {
            ISocketAdapter sockAdapter = new SocketObjetAdapterImp();
            Volt v3 = getVolt(sockAdapter, 3);
            Volt v12 = getVolt(sockAdapter, 12);
            Volt v120 = getVolt(sockAdapter, 120);

            Console.WriteLine("v3 volts using Object adapter = " + v3.Volts.ToString());

            Console.WriteLine("v12 volts using Object adapter = " + v12.Volts.ToString());
            Console.WriteLine("v120 volts using Object adapter = " + v120.Volts.ToString());

        }

        private static void testClassAdapter()
        {
            ISocketAdapter sockAdapter = new SocketClassAdapterImp();
            Volt v3 = getVolt(sockAdapter, 3);
            Volt v12 = getVolt(sockAdapter, 12);
            Volt v120 = getVolt(sockAdapter, 120);

            Console.WriteLine("v3 volts using class adapter = " + v3.Volts.ToString());

            Console.WriteLine("v12 volts using class adapter = " + v12.Volts.ToString());
            Console.WriteLine("v120 volts using class adapter = " + v120.Volts.ToString());

        }


        private static Volt getVolt(ISocketAdapter sockAdapter, int i)
        {
            switch (i)
            {
                case 3: return sockAdapter.get3Volt();
                case 12: return sockAdapter.get12Volt();
                default: return sockAdapter.get120Volt();
            }
        }



        #endregion

        #region Composite

        static void Composite()
        {
            Composite.IShape tri = new Triangle();
            Composite.IShape tri1 = new Triangle();
            Composite.IShape cir = new Composite.Circle();

            Drawing drawing = new Drawing();
            drawing.Shapes.Add(tri1);
            drawing.Shapes.Add(tri1);
            drawing.Shapes.Add(cir);

            drawing.drow("Red");
            drawing.Shapes.Clear();

            drawing.Shapes.Add(tri);
            drawing.Shapes.Add(cir);
            drawing.drow("Green");
        }
        #endregion

        #region Proxy
        static void Proxy()
        {
            ICommandExecuter executer = new CommandExecutorProxy("Sanddip", "wrong_pwd");
            try
            {
                executer.runCommand("ls -ltr");
                executer.runCommand(" rm -rf abc.pdf");
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: "+ e.Message);
            }
        }
        #endregion

        #region Flyweight
        static void FlyweightTest()
        {
            for (int i = 0; i < 20; ++i)
            {
               Flyweight.Circle circle = (Flyweight.Circle) ShapeFactory.GetCircle(getRandomColor());
                circle.X = getRandomX();
                circle.Y = getRandomY();
                circle.setRadius(100);
                circle.Drow();
            }
        }

        private static Flyweight.Color getRandomColor()
        {
            int rtn = (int)((new Random()).Next((int) Flyweight.Color.Count));
            return (Flyweight.Color)rtn;
        }

        private static int getRandomX()
        {
            return new Random().Next(100);
        }
        private static int getRandomY()
        {
            return new Random().Next(100);
        }
        #endregion

        #region Facade
        static void Facade()
        {
            var shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
            

        }
        #endregion

        #region Bridge

        static void BridgeTest()
        {
            Bridge.Shape greenCircle = new Bridge.Circle(100, 100, 10, new Bridge.GreenCircle());

            Bridge.Shape redCircle = new Bridge.Circle(100, 100, 10, new Bridge.RedCircle());

            greenCircle.drow();
            redCircle.drow();
        }
        #endregion

        #region Decorator
        static void DecoratorTest()
        {
            Decorator.IShape circle = new Decorator.Circle();
            Decorator.IShape redCircle = new RedShapeDecorator(new Decorator.Circle());
            Decorator.IShape blueCircle = new BlueShapeDecorator(new Decorator.Circle());
            Decorator.IShape redRectangle = new RedShapeDecorator(new Decorator.Rectangle());

            Decorator.IShape redBlueCircle = new RedShapeDecorator(new BlueShapeDecorator(new Decorator.Circle()));
            

            Console.WriteLine("Circle with normal border");
            circle.draw();

           
            Console.WriteLine("\nCircle of red border");
            redCircle.draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.draw();

            Console.WriteLine("\nCircle of red and blue border ");
            redBlueCircle.draw();
        }
        #endregion

        #region TemplateMethod
        static void TemplateMethodTest()
        {
            HouseTemplate houseType = new WoodenHouse();
            houseType.BuildHouse();
            Console.WriteLine("*************");

            houseType = new GlassHouse();
            houseType.BuildHouse();
        }
        #endregion

        #region Mediator
        static void Mediator()
        {
            IChatMediator mediator = new ChatMediator();
            User user1 = new User(mediator, "Pankaj");
            User user2 = new User(mediator, "Lisa");
            User user3 = new User(mediator, "Saurabh");
            User user4 = new User(mediator, "David");
            mediator.addUser(user1);
            mediator.addUser(user2);
            mediator.addUser(user3);
            mediator.addUser(user4);

            user1.send("Hi All");
        }
        #endregion

        #region Observer
         
        static void ObserverTest()
        {
            //create a subject
            MyTopic topic = new MyTopic();

            //create observers
            IObserver obj1 = new MyTopicSubscriber(name: "Obj1");
            IObserver obj2 = new MyTopicSubscriber(name: "Obj2");
            IObserver obj3 = new MyTopicSubscriber(name: "Obj3");

            //register them
            topic.register(obj1);
            topic.register(obj2);
            topic.register(obj3);

            //attach observer to subject
            obj1.setSubjet(topic);
            obj2.setSubjet(topic);
            obj3.setSubjet(topic);

            //check if any update is available
            obj1.update();

            //now send message to subject
            topic.postMessage("New Message");
        }
        #endregion

        #region ChainOfResponsibility

        static void ChainOfResponsibility()
        {
            ATMDispenseChain atmDispencer = new ATMDispenseChain();
            while(true)
            {
                Console.WriteLine("Enter amount");
                int input = Convert.ToInt32( Console.ReadLine());
                if(input % 10 != 0)
                {
                    Console.WriteLine("Amount should be in multiple of 10s.");
                    return;
                }
                atmDispencer.c1.dispence(new Currency() { Amount = input });
            }
        }


        #endregion

        #region Strategy
        static void StrategyTest()
        {
            ShoppingCart cart = new ShoppingCart();

            Item item1 = new Item("1234", 10);
            Item item2 = new Item("5678", 40);

            cart.items.Add(item1);
            cart.items.Add(item2);

            cart.pay(new PaypalStrategy("tsanhan@gmail.com", "pass"));

            cart.pay(new CreditCardStrategy("Victor Yampolsky", "123456789123456789","786", "12/15"));

        }

        #endregion

        #region Command
        static void CommandTest()
        {
            //Creating the receiver object
            IFileSystemReceiver fs = FileSystemReceiverUtil.getUnderlyingFileSystem();

            //creating command and associating with receiver
            OpenFileCommand openFileCommand = new OpenFileCommand(fs);

            //Creating invoker and associating with Command
            FileInvoker file = new FileInvoker(openFileCommand);

            //perform action on invoker object 
            file.execute();

            WriteFileCommand writeFileCommand = new WriteFileCommand(fs);
            file = new FileInvoker(writeFileCommand);
            file.execute();

            CloseFileCommand closeFileCommand = new CloseFileCommand(fs);
            file = new FileInvoker(closeFileCommand);
            file.execute();
        }
        #endregion

        #region State
        /// <summary>
        /// a simple program to test our implementation of TV Remote using State pattern
        /// </summary>
        static void StateTest()
        {
            TVContext context = new TVContext();
            IState tvStartState = new TVStartState();
            IState tvStopState = new TVStopState();

            context.State = tvStartState;
            context.doAction();

            context.State = tvStopState;
            context.doAction();
        }
        #endregion

        #region Visitor
        static void VisitorTest()
        {
            var items = new List<ItemElement>() { new Book(cost: 20, isbn: "1234"),
                                                  new Book(cost: 100, isbn: "5678"),
                                                  new Fruit(priceKg: 10, wt: 2, nm: "Banana"),
                                                  new Fruit(priceKg: 5, wt: 5, nm: "Apple")};

            IShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int total = items.Sum(x => x.accept(visitor));
            Console.WriteLine("Total Cost = " + total);
        }


        #endregion

        #region Interpreter
        static void InterpreterTest()
        {
            string str1 = "28 in Binary";
            string str2 = "28 in Hexadecimal";

            var ec = new InterpreterClient(new InterpreterContext());
            Console.WriteLine(str1 + " = " + ec.interpret(str1));
            Console.WriteLine(str2 + " = " + ec.interpret(str2));
        }
        #endregion

        #region Iterator
        static void IteratorTest()
        {
            IChannelCollection channels = populateChannels();
            IChannelIterator baseIterator = channels.iterator(ChannelTypeEnum.ALL);
            while (baseIterator.hasNext())
            {
                Channel c = baseIterator.next();
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("******");
            // Channel Type Iterator
            IChannelIterator englishIterator = channels.iterator(ChannelTypeEnum.ENGLISH);
            while (englishIterator.hasNext())
            {
                Channel c = englishIterator.next();
                Console.WriteLine(c.ToString());
            }
        }
        private static IChannelCollection populateChannels()
        {
            IChannelCollection channels = new ChannelCollectionImpl();
            channels.addChannel(new Channel(98.5, ChannelTypeEnum.ENGLISH));
            channels.addChannel(new Channel(99.5, ChannelTypeEnum.HINDI));
            channels.addChannel(new Channel(100.5, ChannelTypeEnum.FRENCH));
            channels.addChannel(new Channel(101.5, ChannelTypeEnum.ENGLISH));
            channels.addChannel(new Channel(102.5, ChannelTypeEnum.HINDI));
            channels.addChannel(new Channel(103.5, ChannelTypeEnum.FRENCH));
            channels.addChannel(new Channel(104.5, ChannelTypeEnum.ENGLISH));
            channels.addChannel(new Channel(105.5, ChannelTypeEnum.HINDI));
            channels.addChannel(new Channel(106.5, ChannelTypeEnum.FRENCH));
            return channels;
        }
        #endregion

        #region Memento
        static void MementoTest()
        {
            FileWriterCaretaker careTaker = new FileWriterCaretaker();
            FileWriterUtil fileWriter = new FileWriterUtil("data.txt");
            fileWriter.write("First Set of Data\n");
            Console.WriteLine(fileWriter + "\n\n");

            //// lets save the file
            careTaker.save(fileWriter);

            //now write something else
            fileWriter.write("Second Set of Data\n");

            //checking file contents
            Console.WriteLine("checking file contents"  );
            Console.WriteLine(fileWriter);

            //lets undo to last save
            careTaker.undo(fileWriter);
            //checking file content again
            Console.WriteLine("checking file contents");
            Console.WriteLine(fileWriter);
        }
        #endregion
        #endregion
    }
}
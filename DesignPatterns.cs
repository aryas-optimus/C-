using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;



//Singleton

//namespace DesignPatterns
//{
//    public sealed class SingletonClass
//    {
//        private static SingletonClass instance;
//        private static object obj;
//        private SingletonClass() { }
//        public static SingletonClass GetInstance()
//        {
//            lock (obj)
//            {
//                if (instance == null)
//                {
//                    instance = new SingletonClass();
//                }
//            }
//            return instance;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            SingletonClass s = SingletonClass.GetInstance();
//            Console.WriteLine("Singleton instance obtained.");
//        }
//    }
//}



//Factory
//namespace FactoryDesignPattern
//{
//    public interface ICar
//    {
//        void Start();
//    }

//    public class SixSeater : ICar
//    {
//        public void Start()
//        {
//            Console.WriteLine("This is a six-seater car");
//        }
//    }

//    public class FourSeater : ICar
//    {
//        public void Start()
//        {
//            Console.WriteLine("This is a four-seater car");
//        }
//    }

//    public class CarFactory
//    {
//        public ICar GetCar(string carType)
//        {
//            switch (carType)
//            {
//                case "SixSeater":
//                    return new SixSeater();
//                case "FourSeater":
//                    return new FourSeater();
//                default:
//                    return null;
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create an instance of CarFactory
//            CarFactory carFactory = new CarFactory();

//            // Use the factory to get a SixSeater car
//            ICar sixSeaterCar = carFactory.GetCar("SixSeater");

//            // Use the factory to get a FourSeater car
//            ICar fourSeaterCar = carFactory.GetCar("FourSeater");

//            // Optionally, you can start the cars
//            sixSeaterCar?.Start();
//            fourSeaterCar?.Start();
//        }
//    }
//}



//Abstract Factory
//    namespace AbstractFactoryPattern
//{
//    namespace FactoryPatterns
//    {
//        // Concrete product classes for Tata
//        public class TataCar : ICar
//        {
//            public void Manufacture()
//            {
//                Console.WriteLine("Manufacturing Tata Car");
//            }
//        }

//        public class TataBike : IBike
//        {
//            public void Manufacture()
//            {
//                Console.WriteLine("Manufacturing Tata Bike");
//            }
//        }

//        // Concrete product classes for Tesla
//        public class TeslaCar : ICar
//        {
//            public void Manufacture()
//            {
//                Console.WriteLine("Manufacturing Tesla Car");
//            }
//        }

//        public class TeslaBike : IBike
//        {
//            public void Manufacture()
//            {
//                Console.WriteLine("Manufacturing Tesla Bike");
//            }
//        }

//        // Abstract product interfaces
//        public interface ICar
//        {
//            void Manufacture(); // Abstract method to manufacture the car
//        }

//        public interface IBike
//        {
//            void Manufacture(); // Abstract method to manufacture the bike
//        }

//        // Abstract factory class
//        public abstract class VehicleCompany
//        {
//            public abstract ICar GetCar(); // Factory method for creating a car
//            public abstract IBike GetBike(); // Factory method for creating a bike
//        }
//        +
//        // Concrete factory for Tesla
//        public class TeslaCompany : VehicleCompany
//        {
//            public override ICar GetCar()
//            {
//                return new TeslaCar(); // Return a Tesla Car
//            }

//            public override IBike GetBike()
//            {
//                return new TeslaBike(); // Return a Tesla Bike
//            }
//        }

//        // Concrete factory for Tata
//        public class TataCompany : VehicleCompany
//        {
//            public override ICar GetCar()
//            {
//                return new TataCar(); // Return a Tata Car
//            }

//            public override IBike GetBike()
//            {
//                return new TataBike(); // Return a Tata Bike
//            }
//        }

//        // Client code to test Abstract Factory
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                // Client code can choose the factory it wants to work with
//                VehicleCompany teslaFactory = new TeslaCompany();
//                VehicleCompany tataFactory = new TataCompany();

//                // Get products from Tesla
//                ICar teslaCar = teslaFactory.GetCar();
//                IBike teslaBike = teslaFactory.GetBike();

//                teslaCar.Manufacture(); // Manufacturing Tesla Car
//                teslaBike.Manufacture(); // Manufacturing Tesla Bike

//                // Get products from Tata
//                ICar tataCar = tataFactory.GetCar();
//                IBike tataBike = tataFactory.GetBike();

//                tataCar.Manufacture(); // Manufacturing Tata Car
//                tataBike.Manufacture(); // Manufacturing Tata Bike
//            }
//        }
//    }
//}



//Dependency Injection

//Constructor Injection

//namespace DI
//{
//    public class Engine
//    {
//        public void Start()
//        {
//            Console.WriteLine("Engine Started");
//        }
//    }

//    public class Car
//    {
//        private Engine _engine;
//        public Car()
//        {
//            _engine = new Engine();  //Directly creating the dependency...Tightly Coupled
//        }
//    }
//}




//namespace DI
//{
//    public class Engine
//    {
//        public void Start()
//        {
//            Console.WriteLine("Engine Started");
//        }
//    }

//    public class Car
//    {
//        private Engine _engine;
//        //Constructor Injection
//        public Car(Engine engine)
//        {
//            _engine = engine;
//        }
//        public void Startcar()
//        {
//            _engine.Start();
//            Console.WriteLine("Car Started!");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Engine engine = new Engine();
//            Car car = new Car(engine);

//            car.Startcar();
//            Console.ReadLine();
//        }
//    }
//}



//Property Injection
//namespace PropertyInjection
//{
//    public class phone
//    {
//        public void Call()
//        {
//            Console.WriteLine("Making a Call...");
//        }
//    }

//    public class Person
//    {
//        //Property for injecting.....Phone will be injected through this property
//        public phone Phone { get; set; }
//        public void UsePhone()
//        {
//            if (Phone != null)
//            {
//                Phone.Call();
//            }
//            else
//            {
//                Console.WriteLine("No Phone Available");
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            phone phone = new phone();
//            Person person = new Person();

//            //Injecting
//            person.Phone = phone;

//            person.UsePhone();
//        }
//    }
//}


//Method Injection
//namespace MethodInjection
//{
//    public class Logger
//    {
//        public void Log(string message)
//        {
//            Console.WriteLine($"Log:{message}");
//        }
//    }

//    //This class uses Logger only when doing calculations
//    public class Calculator
//    {
//        public void Add(int a, int b, Logger logger)
//        {
//            int result = a + b;
//            logger.Log($"Addition result:{result}");
//            Console.WriteLine($"Result:{result}");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Logger logger = new Logger();
//            Calculator calculator = new Calculator();
//            calculator.Add(5, 3, logger);
//        }
//    }
//}



using Patterns.Behavioral.Mediator;
using Patterns.Creational.AbstractFactory;
using Patterns.Creational.Builder;
using Patterns.Creational.FactoryMethod;
using Patterns.Creational.Singleton;
using Patterns.Structural.Facade;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade.
            {
                Console.WriteLine("----    Testing Facade pattern    ----");
                var swimmingPoodSystemsFacade = new SwimmingpoolFacade();
                swimmingPoodSystemsFacade.GoToASwimmingPool();
                Console.WriteLine("----    Testing Facade pattern finished    ----");
                Console.WriteLine(".. press any key to continue testing ..");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------------------");

            // Mediator
            {
                Console.WriteLine("----    Testing Mediator pattern    ----");

                var brain = new BrainMediator();
                var ear = new Ear(brain);
                var face = new Face(brain);

                brain.Ear = ear;
                brain.Face = face;

                ear.HearSounds();

                Console.WriteLine("----    Testing Mediator pattern finished    ----");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------------------");

            // Singleton
            {
                Console.WriteLine("----    Testing Singleton pattern    ----");

                var loggerSingleton = LoggerSingleton.GetInstance();
                loggerSingleton.TestId = 7;

                var loggerSingleton2 = LoggerSingleton.GetInstance();

                Console.WriteLine(loggerSingleton2.ToString());

                Console.WriteLine("----    Testing Singleton pattern finished    ----");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------------------");

            // Builder
            {
                Console.WriteLine("----    Testing Builder pattern    ----");

                var gamingBuilder = new GamingLaptopBuilder();
                var travelingBuilder = new TravelingLaptopBuilder();
                var director = new BuilderDirector(travelingBuilder);

                var laptop = director.ConstructLaptop();

                Console.WriteLine(laptop.ToString());

                director.ChangeBuilderTo(gamingBuilder);

                var laptop2 = director.ConstructLaptop();

                Console.WriteLine(laptop2.ToString());

                Console.WriteLine("----    Testing Builder pattern finished    ----");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------------------");

            // Factory Method
            {
                Console.WriteLine("----    Testing Factory Method pattern    ----");

                Console.WriteLine(ConcreteFactory.CreateProduct(ProductType.Type2));

                Console.WriteLine("----    Testing Factory Method pattern finished    ----");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------------------");

            // Abstract Factory
            {
                Console.WriteLine("----    Testing Abstract Factory pattern    ----");

                AbstractToysFactory factory = new TeddyToyFactory();
                var createdToy = factory.CreateToy();
                Console.WriteLine(createdToy.ToString());

                Console.WriteLine("----    Testing Abstract Factory pattern finished    ----");
                Console.ReadKey();
            }
        }
    }
}

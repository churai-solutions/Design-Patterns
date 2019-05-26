﻿using Patterns.Behavioral.Mediator;
using Patterns.Creational.AbstractFactory;
using Patterns.Creational.Builder;
using Patterns.Creational.FactoryMethod;
using Patterns.Creational.Prototype;
using Patterns.Creational.Singleton;
using Patterns.Structural.Facade;
using System;
using Patterns.Behavioral.Iterator;
using Patterns.Behavioral.Strategy;
using Patterns.Behavioral.TemplateMethod;

namespace Patterns
{
    internal class Program
    {
        private static void Main()
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

            Console.WriteLine("--------------------------------------------------");

            // Prototype
            {
                Console.WriteLine("----    Testing Prototype pattern    ----");

                var prototype = ProtorypeDirector.GetFilledPrototype();
                prototype.Parameter2 = prototype.Parameter2 + " changed!";
                Console.WriteLine(prototype.ToString());

                Console.WriteLine("----    Testing Prototype pattern finished    ----");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------------------");

            // Strategy
            {
                Console.WriteLine("----    Testing Strategy pattern    ----");

                var strategyOne = new StrategyOne();
                var strategyTwo = new StrategyTwo();

                StrategyClient.DoJobUsingSomeStrategy(strategyOne, "data parameter");
                StrategyClient.DoJobUsingSomeStrategy(strategyTwo, "data parameter");

                Console.WriteLine("----    Testing Strategy pattern finished    ----");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------------------");

            // Template Method
            {
                Console.WriteLine("----    Testing Template Method pattern    ----");

                var templateMethodImplementationClassObject = new ConcreteClassWithTemplateMethodUsing();
                templateMethodImplementationClassObject.DoSomeTemplateMethodJob();

                Console.WriteLine("----    Testing Template Method pattern finished    ----");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------------------");

            // Iterator
            {
                Console.WriteLine("----    Testing Iterator pattern    ----");

                var iterator = new EnumerableDataSource(new[] {"one", "two"});

                foreach (var item in iterator)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("----    Testing Iterator pattern finished    ----");
                Console.ReadKey();
            }
        }
    }
}

using Patterns.Facade;
using System;
using Patterns.Mediator;

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
        }
    }
}

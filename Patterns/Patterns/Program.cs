using Patterns.Facade;
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
                Console.ReadKey();
            }
        }
    }
}

using System;

namespace Patterns.Behavioral.Strategy
{
    public sealed class StrategyTwo : IStrategy
    {
        public void DoSomeImportantJob(string parameter)
        {
            Console.WriteLine($"doing some job as strategy 2 and more text and value {parameter}");
        }
    }
}

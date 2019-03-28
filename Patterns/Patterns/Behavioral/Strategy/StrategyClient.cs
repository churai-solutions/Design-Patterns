using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    public sealed class StrategyClient
    {
        public static void DoJobUsingSomeStrategy(IStrategy strategy, string parameter)
        {
            strategy.DoSomeImportantJob(parameter);
        }
    }
}

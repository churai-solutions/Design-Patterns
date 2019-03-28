using System;

namespace Patterns.Behavioral.TemplateMethod
{
    public sealed class ConcreteClassWithTemplateMethodUsing : AbstractClassWithTemplateMethod
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("Primitive operation 1 in algorithm");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("Primitive operation 2 in algorithm");
        }
    }
}

using System;

namespace Patterns.Behavioral.TemplateMethod
{
    public abstract class AbstractClassWithTemplateMethod
    {
        public void DoSomeTemplateMethodJob()
        {
            Console.WriteLine("Template method start ----------------");
            PrimitiveOperation1();
            Console.WriteLine("Template method middle ----------------");
            PrimitiveOperation2();
            Console.WriteLine("Template method finish ----------------");
        }

        protected abstract void PrimitiveOperation1();

        protected abstract void PrimitiveOperation2();
    }
}

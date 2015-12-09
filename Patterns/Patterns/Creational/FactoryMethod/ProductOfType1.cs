namespace Patterns.Creational.FactoryMethod
{
    public class ProductOfType1 : IGeneralProduct
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "I'm product 1";
        }
    }
}

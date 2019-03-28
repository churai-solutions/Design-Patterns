using System;

namespace Patterns.Creational.FactoryMethod
{
    public static class ConcreteFactory
    {
        public static IGeneralProduct CreateProduct(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Type1:
                    return new ProductOfType1();
                case ProductType.Type2:
                    return new ProductOfType2();
                default:
                    throw new ArgumentException("Not supported product type.");
            }
        }
    }
}

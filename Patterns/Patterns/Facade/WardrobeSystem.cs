using System;

namespace Patterns.Facade
{
    sealed class WardrobeSystem
    {
        public Guid TakeClothes(object clothes)
        {
            // Прийняти одяг і повернути номерок.
            Console.WriteLine("Put clothes to wardrobe");
            return Guid.NewGuid();
        }

        public object ReturnClothes(Guid clothesNomber)
        {
            // Прийняти номерок і повернути одяг.
            Console.WriteLine("Take clothes from wardrobe");
            return new object();
        }
    }
}

namespace Patterns.Creational.Prototype
{
    public static class ProtorypeDirector
    {
        public static Prototype GetFilledPrototype()
        {
            return new Prototype
            {
                Name = "Dave",
                Age = "42",
                Parameter1 = "value1",
                Parameter2 = "value2"
            };
        }
    }
}

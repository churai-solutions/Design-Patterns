namespace Patterns.Creational.AbstractFactory
{
    public abstract class AbstractToy
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"My name is {Name}";
        }
    }
}

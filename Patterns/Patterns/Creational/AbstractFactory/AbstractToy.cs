namespace Patterns.Creational.AbstractFactory
{
    public abstract class AbstractToy
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("My name is {0}", Name);
        }
    }
}

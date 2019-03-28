namespace Patterns.Creational.AbstractFactory
{
    public class BoToyFactory : AbstractToysFactory
    {
        public override AbstractToy CreateToy()
        {
            return new BoBearToy();
        }
    }
}
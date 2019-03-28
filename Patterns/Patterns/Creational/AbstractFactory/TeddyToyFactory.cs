namespace Patterns.Creational.AbstractFactory
{
    public class TeddyToyFactory : AbstractToysFactory
    {
        public override AbstractToy CreateToy()
        {
            return new TeddyBearToy();
        }
    }
}
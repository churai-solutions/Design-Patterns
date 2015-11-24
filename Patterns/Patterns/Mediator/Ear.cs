using System;

namespace Patterns.Mediator
{
    public class Ear : BodyPart
    {
        private string _sounds;

        public Ear(BrainMediator mediator) : base(mediator)
        {
        }

        public void HearSounds()
        {
            Console.WriteLine("Starting hearing some sounds ..");
            _sounds = Console.ReadLine();
            Console.WriteLine(".. sounds received");
            Mediator.OnBodyChanged(this);
        }

        public string GetSounds()
        {
            return _sounds;
        }
    }
}

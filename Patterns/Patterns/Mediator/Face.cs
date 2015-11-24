using System;

namespace Patterns.Mediator
{
    public class Face : BodyPart
    {
        public Face(BrainMediator mediator) : base(mediator)
        {
        }

        public void Smile()
        {
            Console.WriteLine("Face reaction: :-)");
        }

        public void AskForDetails()
        {
            Console.WriteLine("Face reaction: Please provide details");
        }
    }
}

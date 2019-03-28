namespace Patterns.Behavioral.Mediator
{
    public abstract class BodyPart
    {
        /// <summary>
        /// Будь яка частина тіла знає про посередника але не знає про інші 
        /// частини тіла що зменшує їх зв'язаність.
        /// </summary>
        protected BrainMediator Mediator;

        protected BodyPart(BrainMediator mediator)
        {
            Mediator = mediator;
        }
    }
}

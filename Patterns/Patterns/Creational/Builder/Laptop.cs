namespace Patterns.Creational.Builder
{
    /// <summary>
    /// Представляє собою складний об"єкт для конструювання.
    /// В спрощеному вигляді.
    /// В дійсності може бути сестемою з різними компонентами
    /// що треба сконструювати.
    /// </summary>
    public sealed class Laptop
    {
        public string Processor { get; set; }
        public string Memory { get; set; }

        public override string ToString()
        {
            return string.Format("Computer configuration: Processor '{0}', Memory '{1}'", Processor, Memory);
        }
    }
}

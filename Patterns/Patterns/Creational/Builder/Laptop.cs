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
            return $"Computer configuration: Processor '{Processor}', Memory '{Memory}'";
        }
    }
}

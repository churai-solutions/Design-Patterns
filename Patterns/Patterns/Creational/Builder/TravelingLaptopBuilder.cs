namespace Patterns.Creational.Builder
{
    /// <summary>
    /// Конкретний будівельник що знає як створити компоненти для подорожувального лептопа.
    /// </summary>
    public sealed class TravelingLaptopBuilder : AbstractBuilder
    {
        public override void SetProcessor()
        {
            LaptopInstance.Processor = "Traveling PROCESSOR";
        }

        public override void SetMemory()
        {
            LaptopInstance.Memory = "Traveling MEMORY";
        }
    }
}

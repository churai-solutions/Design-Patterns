namespace Patterns.Creational.Builder
{
    /// <summary>
    /// Конкретний будівельник що знає як створити компоненти для ігрового лептопа.
    /// </summary>
    public sealed class GamingLaptopBuilder : AbstractBuilder
    {
        public override void SetProcessor()
        {
            LaptopInstance.Processor = "GAMING PROCESSOR";
        }

        public override void SetMemory()
        {
            LaptopInstance.Memory = "GAMING MEMORY";
        }
    }
}

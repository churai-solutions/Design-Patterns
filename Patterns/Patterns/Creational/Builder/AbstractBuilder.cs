namespace Patterns.Creational.Builder
{
    /// <summary>
    /// Абстрактний будівельник.
    /// Містить в собі екземпляр складного об"єкта який створюється .. інстанціює його ..
    /// а також містить інтерфейс для методів конструювання частин складного об"єкта.
    /// </summary>
    public abstract class AbstractBuilder
    {
        protected Laptop LaptopInstance;

        public void CreateLaptop()
        {
            LaptopInstance = new Laptop();
        }

        public Laptop GetFinishedLaptop()
        {
            return LaptopInstance;
        }

        public abstract void SetProcessor();
        public abstract void SetMemory();
    }
}

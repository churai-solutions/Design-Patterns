namespace Patterns.Creational.Builder
{
    /// <summary>
    /// Прораб на будівництві складного об"єкта.
    /// </summary>
    public sealed class BuilderDirector
    {
        private AbstractBuilder _builder;

        public BuilderDirector(AbstractBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilderTo(AbstractBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// Методів констрювання може бути багато.
        /// </summary>
        public Laptop ConstructLaptop()
        {
            _builder.CreateLaptop();
            _builder.SetProcessor();
            _builder.SetMemory();
            return _builder.GetFinishedLaptop();
        }
    }
}

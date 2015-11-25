namespace Patterns.Creational.Singleton
{
    /// <summary>
    /// Проста реалізація патерна без імплементації міжпотокової безпеки.
    /// </summary>
    public sealed class LoggerSingleton
    {
        /// <summary>
        /// 1. Робимо конструктор приватним щоб
        ///    унеможливити створення різних екземплярів.
        /// </summary>
        private LoggerSingleton(){}

        /// <summary>
        /// 2. Створюємо змінню де буде зберігати єдиний
        ///    екземпляр клуса.
        ///    Статична оскільки використовується
        ///    в статичному методі.
        /// </summary>
        private static LoggerSingleton _instance;

        /// <summary>
        /// 3. Додаємо статичний метод який буде надавати
        ///    єдиний екземпляр класа перевіряючи чи такий
        ///    екземпляр уже існує.
        /// </summary>
        public static LoggerSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoggerSingleton();
                return _instance;
            }
            return _instance;
        }

        public int TestId { get; set; }

        public override string ToString()
        {
            return "Instance of LoggerSingleton has id: " + TestId;
        }
    }
}

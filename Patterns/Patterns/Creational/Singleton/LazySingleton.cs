using System;

namespace Patterns.Creational.Singleton
{
    public sealed class LazySingleton
    {
        private LazySingleton() { }

        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton Instance => _instance.Value;

        public int Checkpoint { get; set; }
    }
}

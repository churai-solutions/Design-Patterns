using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

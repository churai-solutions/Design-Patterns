using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Singleton
{
    public sealed class DoubleCheckedLockedSingleton
    {
        private static volatile DoubleCheckedLockedSingleton _instance;

        private static readonly object _syncRoot = new object();

        private DoubleCheckedLockedSingleton()
        {
        }

        public static DoubleCheckedLockedSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckedLockedSingleton();
                        }
                    }
                }
                return _instance;
            }
        }
        
        public int Checkpoint { get; set; }
    }
}

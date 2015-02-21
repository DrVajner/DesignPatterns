using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern.FourthVersion
{
    // Not quite as lazy, but thread-safe without using locks
    public sealed class Singleton : SingletonBase
    {
        private static readonly Singleton instance = new Singleton();

        // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit.
        static Singleton() { }

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}

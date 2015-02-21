using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern.FifthVersion
{
    // Fully lazy instantiation
    public sealed class Singleton : SingletonBase
    {
        private Singleton() { }

        public static Singleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit.
            static Nested() { }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}

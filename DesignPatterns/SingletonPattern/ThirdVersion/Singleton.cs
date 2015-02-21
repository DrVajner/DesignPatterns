using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern.ThirdVersion
{
    // Attempted thread-safety using double-check locking
    // But has it's possible issues
    public sealed class Singleton : SingletonBase
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();

                        }
                    }
                }
                return instance;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern.ZeroVersion
{
    // NOT THREAD-SAFE!!!!!!!!!!!!!
    public sealed class Singleton : SingletonBase
    {
        private static Singleton _instance = new Singleton();
        public static Singleton Instance
        {
            get { return _instance; }
        }

        private Singleton() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class SingletonBase
    {
        public Currency Currencies = new Currency();
        public Country Countries = new Country();

        protected SingletonBase() { }
    }
}

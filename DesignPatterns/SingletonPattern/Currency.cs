using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class Currency
    {
        private List<string> _currencies = new List<string>();

        public Currency()
        {
            _currencies.Add("INR");
            _currencies.Add("USD");
            _currencies.Add("NEP");
            _currencies.Add("GBP");
        }
        public IEnumerable<string> GetCurrencies()
        {
            return (IEnumerable<string>)_currencies;
        }
    }
}

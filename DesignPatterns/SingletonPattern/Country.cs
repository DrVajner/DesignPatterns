using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class Country
    {
        private List<string> _counstries = new List<string>();

        public Country()
        {
            _counstries.Add("India");
            _counstries.Add("Nepal");
            _counstries.Add("USA");
            _counstries.Add("UK");
        }
        public IEnumerable<string> GetCountries()
        {
            return (IEnumerable<string>)_counstries;
        }
    }
}

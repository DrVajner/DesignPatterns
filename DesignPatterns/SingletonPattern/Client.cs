using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.SingletonPattern.SixthVersion;

namespace DesignPatterns.SingletonPattern
{
    public class Client : IClient
    {
        #region IClient Members

        public void DoSomething()
        {
            Console.WriteLine("Currencies:");
            foreach (var item in Singleton.Instance.Currencies.GetCurrencies())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Countries:");
            foreach (var item in Singleton.Instance.Countries.GetCountries())
            {
                Console.WriteLine(item);
            }
        }

        #endregion
    }
}

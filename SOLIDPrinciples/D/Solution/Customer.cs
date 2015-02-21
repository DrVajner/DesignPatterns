using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.D.Solution
{
    class Customer : IDiscount, IDatabase
    {
        private ILogger obj;

        public Customer(ILogger log)
        {
            obj = log;
        }

        #region IDiscount Members

        public double GetDiscount(double totalSales)
        {
            return totalSales;
        }

        #endregion

        #region IDatabase Members

        public void Add(int exHandle)
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());
            }
        }

        #endregion
    }
}

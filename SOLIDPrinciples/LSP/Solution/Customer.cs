using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LSP.Solution
{
    class Customer : IDiscount, IDatabase
    {
        #region IDiscount Members

        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }

        #endregion

        #region IDatabase Members

        public virtual void Add()
        {
        }

        #endregion
    }
}

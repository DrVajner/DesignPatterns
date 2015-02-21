using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LSP.Solution
{
    class Enquiry : IDiscount
    {
        #region IDiscount Members

        public double GetDiscount(double totalSales)
        {
            return totalSales - 5;
        }

        #endregion
    }
}

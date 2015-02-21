using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.O.Solution
{
    class Customer
    {
        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }
    }
}

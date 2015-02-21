using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.O.Problem
{
    class Customer
    {
        private int _custType;

        public int CustType
        {
            get { return _custType; }
            set { _custType = value; }
        }

        public double GetDiscount(double totalSales)
        {
            // These conditions force us to retest all of them each time new one is added.
            if (_custType == 1)
            {
                return totalSales - 100;
            }
            else
            {
                return totalSales - 50;
            }
        }
    }
}

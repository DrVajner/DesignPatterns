using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LSP.Problem
{
    // WTF?
    class Enquiry : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 5;
        }

        public override void Add()
        {
            throw new Exception("Not allowed!");
        }
    }
}

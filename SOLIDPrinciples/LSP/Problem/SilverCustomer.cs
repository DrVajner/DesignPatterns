﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LSP.Problem
{
    class SilverCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 50;
        }
    }
}

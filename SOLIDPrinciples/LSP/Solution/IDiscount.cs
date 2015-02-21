using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LSP.Solution
{
    interface IDiscount
    {
        double GetDiscount(double totalSales);
    }
}

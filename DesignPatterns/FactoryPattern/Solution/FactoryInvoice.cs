using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Solution
{
    class FactoryInvoice
    {
        public static IInvoice GetInvoice(int invoiceType)
        {
            if (invoiceType == 1)
            {
                return new InvoiceWithHeader();
            }
            else
            {
                return new InvoiceWithOutHeader();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Problem
{
    // Issues:
    // 1. Too many news - too many creations.
    // 2. Cannot easily introduce new type of invoice.

    class Client : IClient
    {
        public void GenerateInvoice(int invoiceType)
        {
            object invoice = null;

            if (invoiceType == 1)
            {
                invoice = new InvoiceWithHeader();
                ((InvoiceWithHeader)invoice).Print();
            }
            else if (invoiceType == 2)
            {
                invoice = new InvoiceWithOutHeader();
                ((InvoiceWithOutHeader)invoice).Print();
            }
        }

        #region IClient Members

        public void DoSomething()
        {
            GenerateInvoice(1);
            GenerateInvoice(2);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Solution
{
    class InvoiceWithHeader : IInvoice
    {
        #region IInvoice Members

        public void Print()
        {
            Console.WriteLine("Invoice with header!");
        }

        #endregion
    }
}

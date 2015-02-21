using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Solution
{
    class Client : IClient
    {
        public void PrintInvoice()
        {
            Console.WriteLine("Enter the invoice type");
            
            var invoiceType = Convert.ToInt32(Console.ReadLine());

            var invoice = FactoryInvoice.GetInvoice(invoiceType);

            invoice.Print();
        }

        #region IClient Members

        public void DoSomething()
        {
            PrintInvoice();
        }

        #endregion
    }
}

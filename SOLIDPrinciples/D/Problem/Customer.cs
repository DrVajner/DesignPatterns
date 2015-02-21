using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.D.Problem
{
    class Customer : IDiscount, IDatabase
    {
        private ILogger obj;

        #region IDiscount Members

        public double GetDiscount(double totalSales)
        {
            return totalSales;
        }

        #endregion

        #region IDatabase Members

        public void Add(int exHandle)
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                if (exHandle == 1)
                {
                    obj = new FileLogger();
                }
                else if (exHandle == 2)
                {
                    obj = new EventViewerLogger();
                }
                else
                {
                    obj = new EmailLogger();
                }
                obj.Handle(ex.ToString());
            }
        }

        #endregion
    }
}

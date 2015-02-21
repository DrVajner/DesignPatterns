using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP.Problem
{
    // Class is doing too many things: database + try/catching + logging to file...
    class Customer
    {
        public void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"Error.txt", ex.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP.BetterSolution
{
    class CustomerDecoration
    {
        private Customer _customer;
        private ILogger _logger;

        public CustomerDecoration(ILogger logger)
        {
            _logger = logger;
            _customer = new Customer();
        }

        public void Add()
        {
            try
            {
                _customer.Add();
            }
            catch (Exception ex)
            {
                _logger.Handle(ex);
            }
        }
    }
}

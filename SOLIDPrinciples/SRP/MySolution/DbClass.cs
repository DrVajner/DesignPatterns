using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP.MySolution
{
    class DbClass
    {
        private IDbObject _dbObject;
        private ILogger _logger;

        public DbClass(IDbObject dbObject, ILogger logger)
        {
            _dbObject = dbObject;
            _logger = logger;
        }

        public void Add()
        {
            try
            {
                _dbObject.Add();
            }
            catch (Exception ex)
            {
                _logger.Handle(ex);
            }
        }
    }
}

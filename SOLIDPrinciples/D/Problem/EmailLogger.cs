using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.D.Problem
{
    class EmailLogger : ILogger
    {
        #region ILogger Members

        public void Handle(string error)
        {
            // Send e-mails with errors
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.D.Solution
{
    class EventViewerLogger : ILogger
    {
        #region ILogger Members

        public void Handle(string error)
        {
            // Log error to event viewer
        }

        #endregion
    }
}

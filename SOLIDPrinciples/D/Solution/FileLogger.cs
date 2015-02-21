using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.D.Solution
{
    class FileLogger : ILogger
    {
        #region ILogger Members

        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"Error.txt", error);
        }

        #endregion
    }
}

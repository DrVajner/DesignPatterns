using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP.MySolution
{
    class FileLogger : ILogger
    {
        #region ILogger Members

        public void Handle(Exception ex)
        {
            System.IO.File.WriteAllText(@"Error.txt", DateTime.Now.ToString() + Environment.NewLine + ex.ToString());
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP.BetterSolution
{
    interface ILogger
    {
        void Handle(Exception ex);
    }
}

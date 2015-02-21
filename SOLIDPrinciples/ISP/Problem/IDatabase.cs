using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.ISP.Problem
{
    interface IDatabase
    {
        void Add(); // Old clients are happy with these.
        void Read(); // Added for new clients. [With adding something new, this has become NEW INTERFACE!]
    }
}

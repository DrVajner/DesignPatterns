using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP.MySolution
{
    class DbObjectFactory
    {
        public static IDbObject GetDbObject(DbObjectTypeEnum dbObjectType)
        {
            switch (dbObjectType)
            {
                case DbObjectTypeEnum.Customer:
                    return new Customer();
                default:
                    return null;
            }
        }
    }
}

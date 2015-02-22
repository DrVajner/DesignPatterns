using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    class DPCollection : CollectionBase
    {
        public virtual void Add(string str)
        {
            Console.WriteLine("Added string to collection.");
            List.Add(str);
        }
    }
}

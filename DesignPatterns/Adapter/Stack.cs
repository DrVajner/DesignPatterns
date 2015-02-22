using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    class DPStack : Stack
    {
        public void Push(string str)
        {
            Console.WriteLine("Pushed string to stack.");
            base.Push(str);
        }
    }
}

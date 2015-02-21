using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    class Button : IInterfaceRender
    {
        #region IInterfaceRender Members

        public void Render()
        {
            Console.WriteLine("Rendering button...");
        }

        #endregion
    }
}

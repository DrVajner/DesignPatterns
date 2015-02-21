using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class FactoryButton
    {
        public static IInterfaceRender GetButtonObject()
        {
            return new Button();
        }
    }
}

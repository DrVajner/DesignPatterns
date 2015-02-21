using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class FactoryTextBox
    {
        public static IInterfaceRender GetTextBoxObject()
        {
            return new TextBox();
        }
    }
}

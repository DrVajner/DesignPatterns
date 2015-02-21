using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public abstract class AbstractFactoryPattern
    {
        public static IInterfaceRender GetUIObject(int typeOfObject)
        {
            if (typeOfObject == 1)
            {
                return FactoryTextBox.GetTextBoxObject();
            }
            else
            {
                return FactoryButton.GetButtonObject();
            }
        }
    }
}

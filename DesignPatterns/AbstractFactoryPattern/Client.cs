using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Client : IClient
    {
        public void RenderUIObject()
        {
            Console.WriteLine("Choose UI object to render");

            var typeOfObject = Convert.ToInt32(Console.ReadLine());

            var uiObject = AbstractFactoryPattern.GetUIObject(typeOfObject);

            uiObject.Render();
        }

        #region IClient Members

        public void DoSomething()
        {
            RenderUIObject();
        }

        #endregion
    }
}

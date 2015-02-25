using System;

namespace DesignPatterns.Proxy
{
    class ActualImage : IImageProxy
    {
        private string _image = @"C:\SomeImage.jpg";

        public void LoadImage()
        {
            Console.WriteLine("Load image... " + _image);
        }

        public void PrintImage()
        {
            Console.WriteLine("Print image... " + _image);
        }
    }
}


namespace DesignPatterns.Proxy
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            IImageProxy imageProxy = new ActualImage();
            imageProxy.LoadImage();
            imageProxy.PrintImage();
        }
    }
}

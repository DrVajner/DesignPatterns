
namespace DesignPatterns.Facade
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var order = new Order();
            order.PlaceOrder();
        }
    }
}

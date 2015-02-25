
namespace DesignPatterns.Facade
{
    class Order
    {
        public void PlaceOrder()
        {
            var product = new Product();
            var payment = new Payment();
            var invoice = new Invoice();

            product.GetDetails();
            payment.PayOnline();
            invoice.PrintInvoice();
        }
    }
}


namespace DesignPatterns.Decorator
{
    abstract class OrderDecorator : IOrder
    {
        protected IOrder Order;
        public OrderDecorator(IOrder order)
        {
            Order = order;
        }

        public virtual string Prepare()
        {
            return Order.Prepare();
        }

        public virtual double CalculateCost()
        {
            return Order.CalculateCost();
        }
    }
}

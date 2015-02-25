using System;

namespace DesignPatterns.Decorator
{
    class OrderDrinks : OrderDecorator
    {
        public OrderDrinks(IOrder order)
            : base(order)
        {

        }

        public override string Prepare()
        {
            return base.Prepare() + PrepareDrinks();
        }

        private string PrepareDrinks()
        {
            var prepare = Environment.NewLine + "Take the drink from the freezer" + Environment.NewLine;
            prepare += "Serve in glass";
            return prepare;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 10.12;
        }
    }
}

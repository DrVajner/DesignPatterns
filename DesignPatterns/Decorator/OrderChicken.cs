using System;

namespace DesignPatterns.Decorator
{
    class OrderChicken : OrderDecorator
    {
        public OrderChicken(IOrder order)
            : base(order)
        {

        }

        public override string Prepare()
        {
            return base.Prepare() + PrepareChicken();
        }

        private string PrepareChicken()
        {
            var prepare = Environment.NewLine + "Grill the chicken" + Environment.NewLine;
            prepare += "Stuff in the bread";
            return prepare;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 300.12;
        }
    }
}

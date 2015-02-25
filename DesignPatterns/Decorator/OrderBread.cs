using System;

namespace DesignPatterns.Decorator
{
    public class OrderBread : IOrder
    {
        public string Prepare()
        {
            var prepare = "Bake the bread in oven" + Environment.NewLine;
            prepare += "Serve the bread";
            return prepare;
        }

        public double CalculateCost()
        {
            return 200.30;
        }
    }
}


namespace DesingPatternsInForms.Strategy
{
    public class Maths
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        private Strategy _strategy;

        public void SetStrategy(Strategy strategy)
        {
            _strategy = strategy;
        }
        public int Calculate()
        {
            return _strategy.Calculate(Number1, Number2);
        }
    }
}

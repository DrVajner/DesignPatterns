
namespace DesingPatternsInForms.Strategy
{
    public class AddStrategy : Strategy
    {
        public override int Calculate(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}

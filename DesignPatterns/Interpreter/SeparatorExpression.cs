
namespace DesignPatterns.Interpreter
{
    public class SeparatorExpression : AbstractExpression
    {
        public override void Evaluate(Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}

using System;

namespace DesignPatterns.Interpreter
{
    public class MonthExpression : AbstractExpression
    {
        public override void Evaluate(Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("MM", DateTime.Now.Month.ToString());
        }
    }
}

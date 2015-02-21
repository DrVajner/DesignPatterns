using System;

namespace DesignPatterns.Interpreter
{
    public class DayExpression : AbstractExpression
    {
        public override void Evaluate(Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("DD", DateTime.Now.Day.ToString());
        }
    }
}

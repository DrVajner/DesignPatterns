using System;

namespace DesignPatterns.Interpreter
{
    public class YearExpression : AbstractExpression
    {
        public override void Evaluate(Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("YYYY", DateTime.Now.Year.ToString());
        }
    }
}

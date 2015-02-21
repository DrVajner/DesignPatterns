using System.Collections.Generic;

namespace DesignPatterns.Interpreter
{
    public class Interpreter
    {
        public static string InterpretDate(string text)
        {
            var expressionList = new List<AbstractExpression>();
            var context = new Context(text.Trim());

            foreach (var item in context.Expression.Split(' '))
            {
                switch (item)
                {
                    case "YYYY":
                        expressionList.Add(new YearExpression());
                        break;
                    case "MM":
                        expressionList.Add(new MonthExpression());
                        break;
                    case "DD":
                        expressionList.Add(new DayExpression());
                        break;
                }
            }

            expressionList.Add(new SeparatorExpression());

            foreach (var expression in expressionList)
            {
                expression.Evaluate(context);
            }

            return context.Expression;
        }
    }
}

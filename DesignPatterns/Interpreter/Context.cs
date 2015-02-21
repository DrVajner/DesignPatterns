
namespace DesignPatterns.Interpreter
{
    public class Context
    {
        public string Expression { get; set; }

        public Context(string expression)
        {
            Expression = expression;
        }
    }
}

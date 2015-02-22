
namespace DesignPatterns.Visitor
{
    public class Phone : ICustomerElements
    {
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

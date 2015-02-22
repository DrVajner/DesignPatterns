
namespace DesignPatterns.Visitor
{
    public interface ICustomerElements
    {
        void Accept(IVisitor visitor);
    }
}

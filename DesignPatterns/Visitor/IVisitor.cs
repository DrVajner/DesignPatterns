
namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(Customer customer);
        void Visit(Address address);
        void Visit(Phone phone);
    }
}

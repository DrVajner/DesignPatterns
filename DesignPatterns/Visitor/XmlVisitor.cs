
namespace DesignPatterns.Visitor
{
    internal class XmlVisitor : IVisitor
    {
        public string Data { get; set; }

        public void Visit(Customer customer)
        {
            Data = "<CustomerName>" + customer.Name;
        }

        public void Visit(Address address)
        {
            Data += "<Address1>" + address.Address1 + "</Address1>";
            Data += "<Address2>" + address.Address2 + "</Address2>";
        }

        public void Visit(Phone phone)
        {
            Data += "<Phone>" + phone.Number + "</Phone></CustomerName>";
        }
    }
}

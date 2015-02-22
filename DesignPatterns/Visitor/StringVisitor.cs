using System;

namespace DesignPatterns.Visitor
{
    internal class StringVisitor : IVisitor
    {
        public string Data { get; set; }
        public void Visit(Customer customer)
        {
            Data = "Customer Name:- " + customer.Name + Environment.NewLine;
        }

        public void Visit(Address address)
        {
            Data += "Address 1:- " + address.Address1 + Environment.NewLine;
            Data += "Address 2:- " + address.Address2 + Environment.NewLine;
        }

        public void Visit(Phone phone)
        {
            Data += "Phone:- " + phone.Number + Environment.NewLine;
        }
    }
}

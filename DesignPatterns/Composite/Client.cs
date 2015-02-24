using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var customers = CreateListOfCustomers();

            foreach (IBusinessObject customer in customers)
            {
                customer.Update();
                
                foreach (IBusinessObject address in ((Customer)(customer)).ChildObject)
                {
                    address.Update();

                    foreach (IBusinessObject phone in ((Address)(address)).ChildObjects)
                    {
                        phone.Update();
                    }
                }
            }
        }

        private List<Customer> CreateListOfCustomers()
        {
            var customers = new List<Customer>();
            
            // Customer #1
            var customer = new Customer();
            
            // Address #1.1
            var address = new Address();
            // Phone #1.1.1
            address.Add(new Phone());
            // Phone #1.1.2
            address.Add(new Phone());
            customer.Add(address);
            
            // Address #1.2
            address = new Address();
            // Phone #1.2.1
            address.Add(new Phone());
            customer.Add(address);
            
            customers.Add(customer);
            
            // Customer #2
            customer = new Customer();
            
            // Address #2.1
            address = new Address();
            
            // Phone #2.1.1
            address.Add(new Phone());
            // Phone #2.1.2
            address.Add(new Phone());
            
            customer.Add(address);
            
            customers.Add(customer);
            
            return customers;
        }
    }
}

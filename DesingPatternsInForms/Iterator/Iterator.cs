using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsInForms.Iterator
{
    internal class Iterator
    {
        private int _currentIndex = 0;
        private List<Customer> customerList = new List<Customer>();

        public void FillObjects()
        {
            customerList.AddRange(new[]
            {
                new Customer
                {
                    Name = "Customer 1",
                    Code = "001"
                },
                new Customer
                {
                    Name = "Customer 2",
                    Code = "002"
                },
                new Customer
                {
                    Name = "Customer 3",
                    Code = "003"
                }
            });
        }

        public Customer GetByIndex(int index)
        {
            if ((index >= customerList.Count) || (index < 0))
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }

            _currentIndex = index;
            return customerList[index];
        }

        public Customer GetPrevious()
        {
            var index = _currentIndex;
            index--;
            return GetByIndex(index);
        }

        public Customer GetNext()
        {
            var index = _currentIndex;
            index++;
            return GetByIndex(index);
        }

        public Customer GetFirst()
        {
            return GetByIndex(0);
        }

        public Customer GetLast()
        {
            return GetByIndex(customerList.Count - 1);
        }
    }
}

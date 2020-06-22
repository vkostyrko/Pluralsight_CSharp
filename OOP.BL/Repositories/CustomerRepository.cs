using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.BL.Repositories
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;

namespace OOP.BL
{
    public class Customer
    {
        public Customer() : this(0)
        {

        }
        public Customer(int customerId)
        {
            Addresses = new List<Address>();
            CustomerId = customerId;
        }

        public List<Address> Addresses { get; set; }
        private string _lastName;
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public static int InstanceCount { get; set; }
        public string FullName => $"{FirstName}, {LastName}";


        public string LastName { get => _lastName; set => _lastName = value; }

        public bool Validate()
        {
            string a = "";            
            var isValid = true;
            if (string.IsNullOrWhiteSpace(EmailAddress) || string.IsNullOrWhiteSpace(LastName)) isValid = false;
            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            int [] arrs = new int [] { };
            return new List<Customer>();

        }
    }
     public static class StringHelper
    {
        public static string AddSpaces(this string tetsString)
        {
            return tetsString.Trim();
        }
    }
}

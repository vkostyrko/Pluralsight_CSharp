using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.BL
{
    public class Address
    {

        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(StreetLine1) ||
                string.IsNullOrWhiteSpace(City) ||
                string.IsNullOrWhiteSpace(Country) ||
                string.IsNullOrWhiteSpace(PostalCode))
                return false;
            return true;
        }
    }
}

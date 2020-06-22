using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer() { FirstName = "Bilbo" };
            Customer.InstanceCount += 1;
            var c2 = new Customer() { FirstName = "Frodo" };
            Customer.InstanceCount += 1;
            var c3 = new Customer() { FirstName = "Rosie" };
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void Validate_Valid_ReturnsTrue()
        {
            var customer = new Customer()
            {
                LastName = "Beggins",
                EmailAddress = "fbaggins@hobbiton.com"
            };

            var actual = customer.Validate();

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Validate_Valid_ReturnsFalse()
        {
            var customer = new Customer()
            {                
                EmailAddress = "fbaggins@hobbiton.com"
            };

            var actual = customer.Validate();

            Assert.IsFalse(actual);
        }
    }
}

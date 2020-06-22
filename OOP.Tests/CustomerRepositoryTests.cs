using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;
using OOP.BL.Repositories;

namespace OOP.Tests
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void Retrieve_Returns_Customer()
        {
            var repository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Beggins"
            };

            var actual = repository.Retrieve(1);


            Assert.AreEqual(expected, actual);
        }
    }
}

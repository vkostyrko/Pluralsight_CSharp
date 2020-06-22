using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void Validate_ValidWIthNullDateTime_ReturnsFalse ()
        {
            var order = new Order();

            var actual = order.Validate();

            Assert.IsFalse(actual);
        }
    }
}

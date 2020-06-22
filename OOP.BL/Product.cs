using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null) return false;
            return true;
        }
        public bool Save()
        {
            return true;
        }
    }
}

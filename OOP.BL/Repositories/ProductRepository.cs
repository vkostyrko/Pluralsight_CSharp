using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.BL.Repositories
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);
            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "description";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        public bool Save(Product Product)
        {
            return true;
        }
    }
}

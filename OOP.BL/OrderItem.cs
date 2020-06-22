using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int ordeItemId)
        {
            OrderItemId = ordeItemId;
        }
        public int OrderItemId { get; private set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public OrderItem Retrieve()
        {
            return new OrderItem();
        }

        public bool Validate()
        {
            if (Product == null || PurchasePrice == null) return false;
            return true;
        }
        public bool Save()
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public Order Retrieve()
        {
            return new Order();
        }

        public bool Validate()
        {
            if (OrderDate.GetValueOrDefault().Offset == TimeSpan.Zero) return false;
            return true;
        }
        public bool Save()
        {
            return true;
        }

    }
}

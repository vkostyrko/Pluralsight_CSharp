using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.BL.Repositories
{
    public class OrderRepository
    {
        public Order Retrieve(int oredrId)
        {
            var order = new Order(oredrId);
            if (oredrId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));              
            }
            return order;
        }
        public bool Save(Order order)
        {
            return true;
        }
    }
}

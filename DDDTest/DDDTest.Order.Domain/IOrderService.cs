using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTest.Order.Domain
{
    interface IOrderService
    {
        int PlaceOrder(Order order);
    }
}

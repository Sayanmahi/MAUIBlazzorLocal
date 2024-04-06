using MAUILocal.Data;
using MAUILocal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUILocal.Services
{
    public class OrderService:IOrderService
    {
        public OrderService()
        {
             OrderData.Data();
        }

        public List<Order> GetMyOrders()
        {
            return (OrderData.d);
        }

        public bool PlaceOrder(Order order)
        {
            order.date = DateTime.Now;
            var p = CartData.d.FirstOrDefault(x => x.id == order.id);
            CartData.d.Remove(p);
            order.id = OrderData.d[^1].id + 1;            
            OrderData.d.Add(order);
            return (true);
        }
    }
}

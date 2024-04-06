using MAUILocal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUILocal.Services
{
    public interface IOrderService
    {
        public List<Order> GetMyOrders();
        public bool PlaceOrder(Order order);
    }
}

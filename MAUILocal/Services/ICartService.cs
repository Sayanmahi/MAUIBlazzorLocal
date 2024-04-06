using MAUILocal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUILocal.Services
{
    public interface ICartService
    {
        public bool AddToCart(Cart cart);
        public bool ChangeQuantity(int cid,int quantity);
        public bool Delete(int id);
        public List<Cart> GetAll();
        public int CountItems();
        public Cart GetCartItem(int id);

    }
}

using MAUILocal.Data;
using MAUILocal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUILocal.Services
{
    public class CartService : ICartService
    {
        public CartService()
        {
            var s = CartData.Data();
        }
        public bool AddToCart(Cart cart)
        {
            var p = CartData.d;
            if (p != null)
            {
                cart.id = CartData.d[^1].id + 1;
                var k = ItemData.d.FirstOrDefault(x => x.id == cart.itemId);
                cart.itemname = k.prodname;
                cart.imgur=k.imgur;
                cart.totalPrice = cart.qty * k.price;
                cart.username = "Sayan";
                CartData.d.Add(cart);
                return true;
            }
            else
            {
                cart.id = 1;
                var k = ItemData.d.FirstOrDefault(x => x.id == cart.itemId);
                cart.itemname = k.prodname;
                cart.username = "Sayan";
                CartData.d.Add(cart);
                return true;
            }
        }

        public bool ChangeQuantity(int cid,int quantity)
        {
            var k= CartData.d.FirstOrDefault(x => x.id == cid);
            if (k != null)
            {
                var k1 = ItemData.d.FirstOrDefault(x => x.id == k.itemId);
                k.qty = quantity;
                k.totalPrice = quantity * k1.price;
                return (true);
            }
            return (false);

            }

        public bool Delete(int id)
        {
            var k = CartData.d.FirstOrDefault(x => x.id == id);
            if (k != null)
            {
                CartData.d.Remove(k);
                return (true);
            }
            return (false);
        }
        public List<Cart> GetAll()
        {
            return CartData.d;
        }
        public int CountItems()
        {
            return(CartData.d.Count);
        }
        public Cart GetCartItem(int id)
        {
            var p= CartData.d.FirstOrDefault(x=>x.id == id);
            return (p);
        }
    

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUILocal.Model
{
    public class Cart
    {
        public int id { get; set; }
        public int itemId { get; set; }
        public string itemname { get; set; }
        public string imgur { get; set; }
        public int qty { get; set; }
        public int totalPrice { get; set; }
        public string username { get; set; }


    }
}

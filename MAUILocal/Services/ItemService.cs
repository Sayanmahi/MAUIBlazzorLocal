using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUILocal.Data;
using MAUILocal.Model;

namespace MAUILocal.Services
{
    class ItemService : IItemService
    {
        public ItemService()
        {
            var s = ItemData.Data();
        }
        public List<Items> GetAllItems()
        {
            return ItemData.d;
        }

        public Items getItemById(int id)
        {
            var d = ItemData.d.FirstOrDefault(x => x.id == id);
            return (d);
        }
    }
}

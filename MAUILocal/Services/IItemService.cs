using MAUILocal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUILocal.Services
{
    public interface IItemService
    {
        public List<Items> GetAllItems();
    }
}

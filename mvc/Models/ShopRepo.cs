using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class ShopRepo : IShopRepo
    {
        public IEnumerable<ShopModel> GetItems()
        {
            return new List<ShopModel>
            {
                new ShopModel { ShopItem = "T-shirt", ItemPrice = 20 },
                new ShopModel { ShopItem = "Shoes", ItemPrice = 250 },
                new ShopModel { ShopItem = "Cardigan", ItemPrice = 120 },
                new ShopModel { ShopItem = "Leather Belt", ItemPrice = 99 },
            };
        }
    }
}

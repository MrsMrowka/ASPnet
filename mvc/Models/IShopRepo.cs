using System.Collections.Generic;

namespace mvc.Models
{
    public interface IShopRepo
    {
        IEnumerable<ShopModel> GetItems();
    }
}
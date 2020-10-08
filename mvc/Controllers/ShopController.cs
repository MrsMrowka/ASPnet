using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShopList()
        {
            var list = new List<ShopModel>
            {
                new ShopModel { ShopItem = "T-shirt", ItemPrice = 20 },
                new ShopModel { ShopItem = "Shoes", ItemPrice = 250 },
                new ShopModel { ShopItem = "Cardigan", ItemPrice = 120 },
                new ShopModel { ShopItem = "Leather Belt", ItemPrice = 99 },
            };

            return View(list);
        }
    }
}

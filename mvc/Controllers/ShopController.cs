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
                new ShopModel { ShopItems = "T-shirt" },
                new ShopModel { ShopItems = "Shoes" },
                new ShopModel { ShopItems = "Cardigan" },
                new ShopModel { ShopItems = "Leather Belt" },
            };

            return View(list);
        }
    }
}

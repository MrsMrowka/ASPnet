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
        private readonly IShopRepo repo;

        public ShopController(IShopRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShopList()
        {
            var list = repo.GetItems();
            return View(list);
        }
    }
}

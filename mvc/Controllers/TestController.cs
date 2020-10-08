using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string StringValue()
        {
            return "Hello world!";
        }

        public IActionResult GoogleRedirect()
        {
            return Redirect("https://www.google.com/");
        }

        public IActionResult GetJson()
        {
            return Json(new {Name = "Jan", Surname = "Kowalski" });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RentRoom.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult DataSend()
        {

            return Json(new{id = 5});
        }
        public IActionResult DataGet(string Id)
        {
            
            return Json(new { id = 5 });
        }

    }
}
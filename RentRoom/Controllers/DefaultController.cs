using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace RentRoom.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult DataSend(string firstDayOfWeek)
        {
            //string temp = firstDayOfWeek;
            //string content = System.IO.File.ReadAllText("data.txt");

            string[] DataTable = {"08.06.2018 09 10", "09.06.2018 01", "10.06.2018", "11.06.2018", "12.06.2018", "13.06.2018", "14.06.2018" };
            //return Json(new{id = 5});
            return Json(DataTable);
        }
        public IActionResult DataGet(string Id)
        {
            
            return Json(new { id = 5 });
        }

    }
}
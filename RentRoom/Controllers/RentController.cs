using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentRoom.Classes;
using RentRoom.Context;
using RentRoom.Models;

namespace RentRoom.Controllers
{
    public class RentController : Controller
    {
        private readonly IdentityContext _context;

        public RentController(IdentityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listFromDataBase = _context.RoomDescriptionModels.ToList();

            var listOfRooms = new List<SelectListItem>();

            for (int i = 0; i < listFromDataBase.Count; i++)
            {
                string name = listFromDataBase[i].NameOfRoom;
                listOfRooms.Add(new SelectListItem(name, name));
            }

           // listOfRooms.Add(new SelectListItem(name, name));
            listOfRooms.Add(new SelectListItem("sala2", "sala2"));
            listOfRooms.Add(new SelectListItem("sala3", "sala3"));
            listOfRooms.Add(new SelectListItem("sala4", "sala4"));
            ViewBag.List = listOfRooms;

            return View();
        }

        
        public IActionResult RentRoomTerm()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult RentRoomTerm(string nameOfRoom)
        {
            string temp = nameOfRoom;
            return View();
        }

        [HttpPost]
        public IActionResult RentRoomTermData(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                ComJson myData = new ComJson();
                myData.DataTable = new string[] {"08.06.2018 09 10", "09.06.2018 01", "10.06.2018", "11.06.2018", "12.06.2018", "13.06.2018", "14.06.2018", "11" };
                myData.Hourpreiod = new string[] { "10" , "12"};

                return Json(myData);

            }
            else
            {
                string[] DataTable = { "08.06.2018 09 10", "09.06.2018 01", "10.06.2018", "11.06.2018", "12.06.2018", "13.06.2018", "14.06.2018" };
                return Json(DataTable);
            }
            
            //return Json(new{id = 5});
           
        }
    }
}
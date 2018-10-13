using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentRoom.Context;
using RentRoom.Models;

namespace RentRoom.Controllers
{
    public class RoomDescriptionController : Controller
    {
        private readonly IdentityContext _context;

        public RoomDescriptionController(IdentityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddRoom()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRoom(RoomDescriptionModel roomDescription)
        {
            
            var listFromDataBase = _context.RoomDescriptionModels
                .Where(x => x.NameOfRoom == roomDescription.NameOfRoom)
                .ToList();

            //for (int i = 0; i < listFromDataBase.Count; i++)
            //{
            //    string name = listFromDataBase[i].NameOfRoom;
            //    if (name == roomDescription.NameOfRoom)
            //    {
            //        TempData["Massege"] = "Sala o podanej nazwie juz istneje";
            //        return AddRoom();
            //    }
             
            //}
            //if (listFromDataBase.Contains(name))
            //{

            //}

            //if (string.IsNullOrEmpty(roomDescription.NameOfRoom))
            //{
            //    return Content("Prosze podać nazwę sali");
            //}
            if (ModelState.IsValid)
            { 
            _context.Add(roomDescription);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (roomDescription.Id != default(int))
                {
                    roomDescription.Id = default(int);
                    _context.SaveChanges();
                }
            }
            }
            return AddRoom();
        }
    }
}
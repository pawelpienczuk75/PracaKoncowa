using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string NameOfEmploye { get; set; }
        public string SurnameOfEmploye { get; set; }
        public ICollection<RoomDescriptionModel> DepencyCollectionRoomDescriptionModels { get; set; }
        public ICollection<RoomWeekSchedule> DepencyCollectionRoomWeekSchedules { get; set; }
    }
}

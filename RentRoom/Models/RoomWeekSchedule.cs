using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.Models
{
    public class RoomWeekSchedule
    {
        public int Id { get; set; }
        public string NameOfEvent { get; set; }
        public string NameOfDayWeek { get; set; }
        public string HourOfBeginEvent { get; set; }
        public string HourOfEndEvent { get; set; }
        public string ValidTo { get; set; }
        public Employees Employees { get; set; }
        public RoomDescriptionModel RoomDescriptionModel { get; set; }
    }
}
